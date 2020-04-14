namespace Storage_App
{
    using System.Windows;
    using Storage_App.Models;
    using System.Collections.Generic;

    public partial class MainWindow : Window
    {
        My_Context db;

        public MainWindow()
        {
            InitializeComponent();
            db = new My_Context();
        }

        private void okBtn_Click(object sender, RoutedEventArgs e)
        {
            // Вытягиваем всех юзеров с таблици в List:
            List<User> users = ReadFromDatabase.Read_All_Users();
            string login = loginTxt.Text;
            string password = passTxt.Password;
            bool flag = false;
            string mode = string.Empty;

            if (loginTxt.Text == "" && passTxt.Password == "")
                MessageBox.Show("All fields is Empty.. Try fill it, and once again!", "All fields was Empty",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
            else if (loginTxt.Text == "" || passTxt.Password == "")
                MessageBox.Show("Some of field is Empty.. Try fill it, and once again!", "Some of the field was Empty", 
                    MessageBoxButton.OK, MessageBoxImage.Warning);
            else
            {
                for (int i = 0; i < users.Count; i++)
                    if (login == users[i].Login && password == users[i].Password && users[i].Role == "admin")
                    {
                        flag = true;
                        if (rememberCheck.IsChecked == true)
                        {
                            mode = users[i].Role;
                            new Main_Area(mode, $"Hello {users[i].First_Name} {users[i].Last_Name}!", users[i].Id_WorkArea).ShowDialog();
                        }
                        else if (rememberCheck.IsChecked == false)
                        {
                            loginTxt.Text = "";
                            passTxt.Password = "";
                            mode = users[i].Role;
                            new Main_Area(mode, $"Hello - {users[i].First_Name} {users[i].Last_Name}!", users[i].Id_WorkArea).ShowDialog();
                        }
                    }
                    else if (login == users[i].Login && password == users[i].Password && users[i].Role == "user")
                    {
                        flag = true;
                        if (rememberCheck.IsChecked == true)
                        {
                            mode = users[i].Role;
                            new Main_Area(mode, $"Hello - {users[i].First_Name} {users[i].Last_Name}!", users[i].Id_WorkArea).ShowDialog();
                        }
                        else if (rememberCheck.IsChecked == false)
                        {
                            loginTxt.Text = "";
                            passTxt.Password = "";
                            mode = users[i].Role;
                            new Main_Area(mode, $"Hello - {users[i].First_Name} {users[i].Last_Name}!", users[i].Id_WorkArea).ShowDialog();
                        }
                    }

                if (!flag)
                    MessageBox.Show("Wrong login & password.. Try again", "Incorrect of user", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void regBtn_Click(object sender, RoutedEventArgs e)
        {
            if (rememberCheck.IsChecked == true)
                new Register_Window().ShowDialog();
            else if (rememberCheck.IsChecked == false)
            {
                loginTxt.Text = "";
                passTxt.Password = "";
                new Register_Window().ShowDialog();
            }
        }
    }
}
