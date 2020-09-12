namespace Storage_Admin_App
{
    using System.Linq;
    using System.Windows;
    using Storage_Admin_App.Model;
    using Storage_Admin_App.Windows;
    using System.Collections.Generic;
    using System.Windows.Media;

    public partial class MainWindow : Window
    {
        MyContext db;
        public MainWindow()
        {
            InitializeComponent();
            db = new MyContext();
        }

        private void login_btn_Click(object sender, RoutedEventArgs e)
        {
            login_txt.BorderBrush = Brushes.Silver;
            passwd_txt.BorderBrush = Brushes.Silver;
            if (login_txt.Text.Equals(string.Empty) && passwd_txt.Password.Equals(string.Empty))
            {
                login_txt.BorderBrush = Brushes.Red;
                passwd_txt.BorderBrush = Brushes.Red;
                //MessageBox.Show("All fields is empty... Try to fill out this!", "empty",
                //    MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else if (login_txt.Text.Equals(string.Empty) || passwd_txt.Password.Equals(string.Empty))
            {
                if(login_txt.Text.Equals(""))
                    login_txt.BorderBrush = Brushes.Red;
                else passwd_txt.BorderBrush = Brushes.Red;
                //MessageBox.Show("Some of the field is empty... Try to fill out this!", "empty",
                //   MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                List<User> check_user = db.Users.ToList();
                List<UsersSessions> list = ReadFromDatabase.AllUsersSessions().ToList();
                for (int i = 0; i < check_user.Count; i++)
                {
                    if (login_txt.Text == check_user[i].Login && passwd_txt.Password == check_user[i].Password && check_user[i].Role == "admin")
                    {
                        UsersSessions session = new UsersSessions();
                        session.CurLogin = login_txt.Text;
                        session.CurPaswd = passwd_txt.Password;
                        session.Rememb = System.Convert.ToBoolean(remeber_check.IsChecked);
                        session.LastEnterDate = System.DateTime.Now;
                        db.UsersSessions.Add(session);
                        db.SaveChanges();

                        list = ReadFromDatabase.AllUsersSessions().ToList();

                        for (int s = 0; s < list.Count; s++)
                        {
                            if(login_txt.Text == list[list.Count - 1].CurLogin && passwd_txt.Password == list[list.Count - 1].CurPaswd)
                            {
                                if (remeber_check.IsChecked == true)
                                {
                                    login_txt.Text = list[list.Count - 1].CurLogin;
                                    passwd_txt.Password = list[list.Count - 1].CurPaswd;
                                    remeber_check.IsChecked = true;
                                    new WorkAreas().ShowDialog();
                                }
                                else new WorkAreas().ShowDialog();
                            }
                            else
                            {
                               
                            }
                        }
                    }
                    else if(login_txt.Text == check_user[i].Login && passwd_txt.Password == check_user[i].Password && check_user[i].Role == "user")
                    {
                        
                    }
                    else MessageBox.Show("This user does not exist");
                }

            }
        }

        private void reg_btn_Click(object sender, RoutedEventArgs e)
        {
            new Register().ShowDialog();
        }
    }
}
