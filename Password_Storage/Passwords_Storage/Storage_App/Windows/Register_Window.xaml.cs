namespace Storage_App
{
    using System;
    using System.Windows;
    using Storage_App.Models;

    public partial class Register_Window : Window
    {
        My_Context db;
        public Register_Window()
        {
            InitializeComponent();
            db = new My_Context();
        }

        private void okBtn_Click(object sender, RoutedEventArgs e)
        {
            if (fnameTxt.Text == "" && lnameTxt.Text == "" && loginTxt.Text == "" &&
                passTxt.Text == "" && roleTxt.Text == "" && ageTxt.Text == "")
                MessageBox.Show("All fields is EMPTY... Try to fill it!", "EMPTY",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
            else if (fnameTxt.Text == "" || lnameTxt.Text == "" || loginTxt.Text == "" ||
               passTxt.Text == "" || roleTxt.Text == "" || ageTxt.Text == "")
                MessageBox.Show("Some of field is EMPTY... Try to fill it!", "Some one was EMPTY",
                                   MessageBoxButton.OK, MessageBoxImage.Warning);
            else
            {
                try
                {
                    System.Collections.Generic.List<User> nextNumb = ReadFromDatabase.Read_All_Users();
                    int uniq_numb = nextNumb.Count + 1; // Generate uniq number to name for create new Table 

                    User user = new User
                    {
                        First_Name = fnameTxt.Text,
                        Last_Name = lnameTxt.Text,
                        Login = loginTxt.Text,
                        Password = passTxt.Text,
                        Role = roleTxt.Text,
                        Age = ageTxt.Text,
                        Id_WorkArea = uniq_numb,
                        Date_Register = DateTime.Now
                    };
                    db.Users.Add(user);
                    db.SaveChanges();

                    // After that has creating a new Table Work_Area_1, 2, 3, 4 ... etc:
                    db.Database.ExecuteSqlCommand($"CREATE TABLE [dbo].[Work_Area_{uniq_numb}](" +
                        $"[Id][int] IDENTITY(1, 1) NOT NULL, " +
                        $"[Site_Name][nvarchar](150) NULL, " +
                        $"[Email][nvarchar](50) NULL," +
                        $"[Login][nvarchar](50) NULL, " +
                        $"[Password][nvarchar](50) NULL," +
                        $"[URL][nvarchar](255) NULL, " +
                        $"[Phone][nvarchar](50) NULL," +
                        $"[Comments][text] NULL," +
                        $"[DateCreated][datetime] NULL)");

                    MessageBox.Show($"User - {fnameTxt.Text} was added successfully!", "Congratulate!",
                        MessageBoxButton.OK, MessageBoxImage.Asterisk);

                    // After correct adding clear all text fields:
                    fnameTxt.Text = lnameTxt.Text = loginTxt.Text = 
                    passTxt.Text = roleTxt.Text = ageTxt.Text = "";
                }
                catch(Exception ex) 
                {
                    MessageBox.Show(ex.Message, "System Exception..Failed..",
                      MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
