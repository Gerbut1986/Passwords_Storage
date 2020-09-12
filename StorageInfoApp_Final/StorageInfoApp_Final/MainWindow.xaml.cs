namespace StorageInfoApp_Final
{
    using System;
    using System.Linq;
    using System.Windows;
    using System.Windows.Input;
    using System.Windows.Media;
    using StorageInfoApp_Final.DAO;
    using System.Collections.Generic;
    using StorageInfoApp_Final.Models;
    using StorageInfoApp_Final.Windows;

    public partial class MainWindow : Window
    {
        MyContext db;
        UsersSessions session;
        List<User> users;
        int currrent_id, num_table, indx_last_user = 0;
        public bool flag = false;
        User lastUser = null, currUser;
        Guid token;
        public string TextLogin { get; set; }

        public MainWindow()
        {
            InitializeComponent();

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

        void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        void log_btn_Click(object sender, RoutedEventArgs e)
        {
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

       // void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e) { return; }

        void close_btn_Click(object sender, RoutedEventArgs e)
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
                Close();
            }
            else this.Close();
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

            if (list == null)
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
