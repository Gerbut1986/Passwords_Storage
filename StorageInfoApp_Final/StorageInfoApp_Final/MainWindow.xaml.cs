namespace StorageInfoApp_Final
{
    using System;
    using System.Linq;
    using System.Windows;
    using System.Windows.Input;
    using System.Windows.Media;
    using System.Windows.Threading;
    using StorageInfoApp_Final.DAO;
    using System.Collections.Generic;
    using StorageInfoApp_Final.Models;
    using StorageInfoApp_Final.Windows;

    public partial class MainWindow : Window
    {
        Guid token;
        MyContext db;
        List<User> users;
        UsersSessions session;
        public bool flag = false;
        DispatcherTimer text_timer = null;
        User lastUser = null, currUser;
        int currrent_id, num_table, indx_last_user = 0, time_shw_txt, txt_cnt = 0;

        public MainWindow()
        {
            InitializeComponent();

            text_timer = new DispatcherTimer();  
            text_timer.Tick += Timer_Tick;
            text_timer.Interval = new TimeSpan(0, 0, 0, 0, 1000);
            text_timer.Start();
            time_shw_txt = 1;

            db = new MyContext();
            session = new UsersSessions();
            try
            {
                users = ReadFromDatabase.ShowAllUsers().ToList();
            }
            catch { users = new List<User>(); }

            if (users.Count != 0)
            {
                try
                {
                    for (int i = 0; i < users.Count; i++)
                    {
                        User user = db.Users.Where(u => u.Id == i + 1).FirstOrDefault();

                        if (user.Indx_Last_Enter > indx_last_user)
                        {
                            indx_last_user = user.Indx_Last_Enter;
                            lastUser = users[i];
                        }
                        user.Indx_Last_Enter = 0;
                        db.SaveChanges();
                    }

                    if (lastUser == null) { return; }
                    else
                    {
                        UsersSessions[] sessions = ReadFromDatabase.AllUsersSessions(lastUser.Id_WorkArea).ToArray();

                        if (sessions[sessions.Count() - 1].RememberMe == true)
                        {
                            remeber_check.IsChecked = true;
                            login_txt.Text = lastUser.Login;
                            passwd_txt.Password = lastUser.Password;
                        }
                    }
                }
                catch (Exception ex) { this.Title = ex.Message; }
            }
            else return;
        }

        void Timer_Tick(object sender, EventArgs e)
        {
            time_shw_txt++;
            if (time_shw_txt == 6)  // After 6 sec shown the text
                about_txt.Content = "Hover over the logo to view the text!";
        }

        void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        void log_btn_Click(object sender, RoutedEventArgs e)
        {
            CloseSession();
            if (login_txt.Text.Equals("Username:") && passwd_txt.Password.Equals("Password:"))
            {
                login_txt.Background = Brushes.Red;
                passwd_txt.Background = Brushes.Red;
            }
            else if (login_txt.Text.Equals("Username:") || passwd_txt.Password.Equals("Password:"))
            {
                if (login_txt.Text.Equals("Username:") || login_txt.Text.Equals(string.Empty))
                    login_txt.Background = Brushes.Red;
                else if (passwd_txt.Password.Equals("Password:"))
                    passwd_txt.Background = Brushes.Red;
            }
            else if (login_txt.Text.Equals(string.Empty) && passwd_txt.Password.Equals(string.Empty))
            {
                login_txt.Background = Brushes.Red;
                passwd_txt.Background = Brushes.Red;
            }
            else if (login_txt.Text.Equals(string.Empty) || passwd_txt.Password.Equals(string.Empty))
            {
                if (login_txt.Text.Equals(""))
                    login_txt.Background = Brushes.Red;
                else passwd_txt.Background = Brushes.Red;
            }
            else if (login_txt.Text.Equals("Username:") && passwd_txt.Password.Equals(string.Empty))
            {
                login_txt.Background = Brushes.Red;
                passwd_txt.Background = Brushes.Red;
            }
            else if (login_txt.Text.Equals(string.Empty) && !passwd_txt.Password.Equals(""))
            {
                login_txt.Background = Brushes.Red;
                passwd_txt.Background = Brushes.Red;
            }
            else
            {
                List<User> check_user = null;
                try
                {
                    check_user = db.Users.ToList();
                }
                catch { }

                if (check_user.Count != 0)
                {
                    for (int i = 0; i < check_user.Count; i++)
                    {
                        if (login_txt.Text == check_user[i].Login && passwd_txt.Password == check_user[i].Password && check_user[i].Role == "admin")
                            EnteredAdminUser(check_user[i]);
                        else if (login_txt.Text == check_user[i].Login && passwd_txt.Password == check_user[i].Password && check_user[i].Role == "user")
                            EnteredAdminUser(check_user[i]);
                    }
                    if (!flag)
                    {
                        MessageBox.Show("This user does not exist", "Doesn't exist", MessageBoxButton.OK, MessageBoxImage.Warning);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("This user does not exist", "Doesn't exist", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
            }
        }

        void reg_btn_Click(object sender, RoutedEventArgs e)
        {
            Register reg = new Register();
            reg.ShowDialog();
        }

        void close_btn_Click(object sender, RoutedEventArgs e)
        {
            CloseSession();
            this.Close();
        }

        void CloseSession()
        {
            if (lastUser != null)
            {
                User u = db.Users.Where(s => s.Id == lastUser.Id).FirstOrDefault();
                u.Indx_Last_Enter = indx_last_user;
                db.SaveChanges();
            }
            else if (currUser != null)
            {
                User uu = db.Users.Where(i => i.Id == currUser.Id).FirstOrDefault();
                uu.Indx_Last_Enter = indx_last_user + 1;
                db.SaveChanges();
                session.DateLeave = DateTime.Now;
                InsertLogic.AddUserSession(session, num_table);
            }
        }

        void login_txt_LostFocus(object sender, RoutedEventArgs e)
        {
            if (login_txt.Text.Equals(""))
                login_txt.Text = "Username:";
        }

        void passwd_txt_LostFocus(object sender, RoutedEventArgs e)
        {
            if (passwd_txt.Password.Equals(""))
                passwd_txt.Password = "Password:";
        }

        void Image_MouseEnter(object sender, MouseEventArgs e)
        {
            int indx = txt_cnt < 3 ? txt_cnt++ : txt_cnt = 0;
            text_timer.Stop();
            about_txt.Content = GetHoverText()[txt_cnt == 0 ? txt_cnt++ : indx];
        }

        void Image_MouseLeave(object sender, MouseEventArgs e) => about_txt.Content = "";

        void reg_btn_MouseEnter(object sender, MouseEventArgs e) => bottom_txt.Content = "Register a new user";

        void reg_btn_MouseLeave(object sender, MouseEventArgs e) => bottom_txt.Content = "";

        void log_btn_MouseEnter(object sender, MouseEventArgs e) => bottom_txt.Content = "Log in if you are registered";

        void log_btn_MouseLeave(object sender, MouseEventArgs e) => bottom_txt.Content = "";

        void remeber_check_MouseEnter(object sender, MouseEventArgs e) => rememb_txt.Content = "Check the box to remember your login on the next time";

        void remeber_check_MouseLeave(object sender, MouseEventArgs e) => rememb_txt.Content = "";

        string[] GetHoverText() => new string[]
            {
                "Developed by Andriy Gerbut.",
                "The app has a local database",
                "All your data will be protected!"
            };

        void login_txt_GotFocus(object sender, RoutedEventArgs e)
        {
            passwd_txt.Background = Brushes.Transparent;
            login_txt.Text = "";
            login_txt.Background = Brushes.Transparent;
        }

        void passwd_txt_GotFocus(object sender, RoutedEventArgs e)
        {
            passwd_txt.Password = "";
            passwd_txt.Background = Brushes.Transparent;
            login_txt.Background = Brushes.Transparent;
        }

        void EnteredAdminUser(User check_user)
        {
            currUser = check_user;
            check_user.Indx_Last_Enter = indx_last_user + 1;

            flag = true;
            num_table = check_user.Id_WorkArea;
            currrent_id = check_user.Id;
            List<UsersSessions> list = null;

            try
            {
                list = ReadFromDatabase.AllUsersSessions(num_table).ToList();
                UsersSessions uSession = list.SingleOrDefault(s => s.Id_User == check_user.Id_WorkArea);
                if (uSession == null) this.Title = "This property Id_User doesn't exist...";
                else
                    token = uSession.AccessToken;
            }
            catch (Exception ex) { this.Title = ex.Message; }

            if (list == null || list.Count == 0)
            {
                db.Database.ExecuteSqlCommand(
                 $"CREATE TABLE [dbo].[UserSessions_{num_table}] (" +
                 $"[Id]          INT           IDENTITY(1, 1) NOT NULL," +
                 $"[CurLogin]    NVARCHAR(50) NULL," +
                 $"[CurPassword] NVARCHAR(50)    NULL," +
                 $"[RememberMe]  Bit NULL," +
                 $"[IsActive]    Bit NULL," +
                 $"[Id_User]     int  NULL," +
                 $"[AccessToken]    uniqueidentifier NULL," +
                 $"[DateEnter]   datetime NULL," +
                 $"[DateLeave]   datetime NULL)");

                text_timer.Stop();

                session = new UsersSessions();
                session.CurLogin = login_txt.Text;
                session.CurPassword = passwd_txt.Password;
                session.RememberMe = Convert.ToBoolean(remeber_check.IsChecked);
                session.Id_User = check_user.Id_WorkArea;
                session.DateEnter = DateTime.Now;
                session.AccessToken = Guid.NewGuid();

                WorkAreas area_window = new WorkAreas(check_user.Id_WorkArea, check_user.Role, $"{check_user.First_Name} {check_user.Last_Name}", this);
                area_window.Owner = this;
                area_window.ShowDialog();
            }
            else
            {
                text_timer.Stop();
                session = new UsersSessions();
                session.CurLogin = login_txt.Text;
                session.CurPassword = passwd_txt.Password;
                session.RememberMe = Convert.ToBoolean(remeber_check.IsChecked);
                session.Id_User = check_user.Id_WorkArea;
                session.DateEnter = DateTime.Now;
                session.AccessToken = Guid.NewGuid();

                new WorkAreas(check_user.Id_WorkArea, check_user.Role, $"{check_user.First_Name} {check_user.Last_Name}", this).ShowDialog();
            }
        }
    }
}
