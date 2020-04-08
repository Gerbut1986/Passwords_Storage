namespace Storage_App
{
    using System;
    using System.Windows;
    using Storage_App.Models;

    public partial class Main_Area : Window
    {
        string mode;
        int uniq_numb;
        My_Context db;

        public Main_Area(string mode, string user_name, int uniq_numb)
        {
            InitializeComponent();
            this.mode = mode;
            this.uniq_numb = uniq_numb;
            db = new My_Context();
            Entered_Name.Content = user_name;
            if (mode == "user") // Eсли текущий пользователь с ролью "user"
                usersBtn.Visibility = Visibility.Hidden; // ..прячем кнопку "Show Users"
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (nameTxt.Text == "" && emailTxt.Text == "" && loginTxt.Text == "" &&
                    passTxt.Text == "" && urlTxt.Text == "" && phoneTxt.Text == "" && commentTxt.Text == "")
                    MessageBox.Show("All Fields is EMPTY..\nTry to Filling it!", "All Fields was EMPTY", MessageBoxButton.OK, MessageBoxImage.Warning);
                else if (nameTxt.Text == "" || emailTxt.Text == "" || loginTxt.Text == "" ||
                   passTxt.Text == "" || urlTxt.Text == "" || phoneTxt.Text == "" || commentTxt.Text == "")
                    MessageBox.Show("Some of Field is EMPTY..\nTry to Filling it!", "Some one Field EMPTY", MessageBoxButton.OK, MessageBoxImage.Warning);
                else
                {
                    Work_Area area = new Work_Area
                    {
                        Site_Name = nameTxt.Text,
                        Email = emailTxt.Text,
                        Login = loginTxt.Text,
                        Password = passTxt.Text,
                        URL = urlTxt.Text,
                        Phone = phoneTxt.Text,
                        Comments = commentTxt.Text,
                        DateCreated = DateTime.Now
                    };

                    string msg = new Add_WorkArea().Insert(area, uniq_numb);
                    MessageBox.Show($"Datas about sitename {nameTxt.Text} was added successfully!",
                        msg, MessageBoxButton.OK, MessageBoxImage.Asterisk);

                    // After correct adding clear all text fields:
                    nameTxt.Text = emailTxt.Text = loginTxt.Text =
                    passTxt.Text = urlTxt.Text = phoneTxt.Text = commentTxt.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System Exception..Failed..",
                  MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void showBtn_Click(object sender, RoutedEventArgs e)
        {
            if (ReadFromDatabase.Read_All_Infos(uniq_numb).Count == 0)
                MessageBox.Show("The table 'Work_Area' is Empty...\nFirst try to filling it!", "Empty table",
                     MessageBoxButton.OK, MessageBoxImage.Warning);
            else new Show_Infos(mode, uniq_numb).Show();
        }

        private void usersBtn_Click(object sender, RoutedEventArgs e)
        {
            if (ReadFromDatabase.Read_All_Infos(uniq_numb).Count == 0)
                MessageBox.Show("The table 'Users' is Empty...\nFirst try to filling it!", "Empty table",
                     MessageBoxButton.OK, MessageBoxImage.Warning);
            else new Show_Users().Show();
        }

        private void logoutBtn_Click(object sender, RoutedEventArgs e) => Close();
    }
}
