namespace StorageInfoApp_Final.Windows
{
    using System;
    using System.Linq;
    using System.Windows;
    using System.Collections.Generic;
    using StorageInfoApp_Final.Models;

    public partial class Register : Window
    {
        MyContext db;

        public Register()
        {
            InitializeComponent();
            role_txt.IsReadOnly = true;
            db = new MyContext();

            int size = ReadFromDatabase.ShowAllUsers().Count();
            if (size == 0)
            {
                MessageBox.Show("To get started you should create an aplication owner with the Admin role. Jast you will have this role.\nAll" +
                    "subsequent users will play the role 'user'", "Create 1st Owner", MessageBoxButton.OK, MessageBoxImage.Information);
                role_txt.Text = "admin";
            }
            else role_txt.Text = "user";
        }

        void close_btn_Click(object sender, RoutedEventArgs e) => Close();

        void Window_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.LeftButton == System.Windows.Input.MouseButtonState.Pressed)
                DragMove();
        }

        void reg_btn_Click(object sender, RoutedEventArgs e) => AddUser();

        void AddUser()
        {

            if (fName_txt.Text == null && login_txt.Text == null && pass_txt.Text == null && email_txt.Text == null &&
               phone_txt.Text == null && fName_txt.Text == null && role_txt.Text == null && age_txt.Text == null)
            {
                MessageBox.Show("All fields is empty", "empty", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else if (fName_txt.Text == null || login_txt.Text == null || pass_txt.Text == null || email_txt.Text == null ||
               phone_txt.Text == null || fName_txt.Text == null || role_txt.Text == null || age_txt.Text == null)
            {
                MessageBox.Show("Some of field are empty", "empty", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                User add_wa = null;
                try
                {
                    using (MyContext db = new MyContext())
                    {
                        List<User> users = ReadFromDatabase.ShowAllUsers().ToList();
                        int num_table = users.Count + 1;

                        try
                        {
                            add_wa = new User();
                            add_wa.Last_Name = lName_txt.Text;
                            add_wa.First_Name = fName_txt.Text;
                            add_wa.Login = login_txt.Text;
                            add_wa.Password = pass_txt.Text;
                            add_wa.Email = email_txt.Text;
                            add_wa.Phone = phone_txt.Text;
                            add_wa.Role = role_txt.Text;
                            add_wa.Id_WorkArea = num_table;
                            add_wa.Indx_Last_Enter = num_table;
                            add_wa.Age = Convert.ToInt32(age_txt.Text);
                            add_wa.Date_Registr = DateTime.Now;

                            //string msg = InsertLogic.AddUser(add_wa, num_table);
                            db.Users.Add(add_wa);
                            var num = db.SaveChanges();
                        }
                        catch { }           

                        int s = db.Database.ExecuteSqlCommand(
                              $"CREATE TABLE [dbo].[WorkAreas_{num_table}] (" +
                              $"[Id]         INT           IDENTITY(1, 1) NOT NULL," +
                              $"[SiteName]   NVARCHAR(50) NULL," +
                              $"[Email]      NVARCHAR(50) NULL," +
                              $"[Login]      NVARCHAR(50) NULL," +
                              $"[Password]   NVARCHAR(50) NULL," +
                              $"[URL]        NVARCHAR(50) NULL," +
                              $"[Phone]      NVARCHAR(50) NULL," +
                              $"[Coments]    NVARCHAR(50) NULL," +
                              $"[DateCreate] DATETIME      NULL)");

                        this.Close();
                        new Congratulate_Wnd($"User - {add_wa.First_Name}", "Has been added Successfully!").ShowDialog();
                    }
                }
                catch (System.Data.Entity.Core.UpdateException ex)
                {
                    string exc = ex.Message;
                }
            }
        }

        // Get & Lost Focus for text fields:
        // Get:
        void fName_txt_GotFocus(object sender, RoutedEventArgs e) { fName_txt.Text = ""; }

        void lName_txt_GotFocus(object sender, RoutedEventArgs e) => lName_txt.Text = "";

        void age_txt_GotFocus(object sender, RoutedEventArgs e) => age_txt.Text = "";

        void login_txt_GotFocus(object sender, RoutedEventArgs e) => login_txt.Text = "";

        void pass_txt_GotFocus(object sender, RoutedEventArgs e) => pass_txt.Text = "";

        void phone_txt_GotFocus(object sender, RoutedEventArgs e) => phone_txt.Text = "";

        void email_txt_GotFocus(object sender, RoutedEventArgs e) => email_txt.Text = "";

        // Lost:
        void fName_txt_LostFocus(object sender, RoutedEventArgs e)
        {
            if (fName_txt.Text.Equals(""))
                fName_txt.Text = "First Name:";
        }

        void lName_txt_LostFocus(object sender, RoutedEventArgs e)
        {
            if (lName_txt.Text.Equals(""))
                lName_txt.Text = "Last Name:";
        }

        void age_txt_LostFocus(object sender, RoutedEventArgs e)
        {
            if (age_txt.Text.Equals(""))
                age_txt.Text = "Age:";
        }

        void login_txt_LostFocus(object sender, RoutedEventArgs e)
        {
            if (login_txt.Text.Equals(""))
                login_txt.Text = "Login:";
        }

        void pass_txt_LostFocus(object sender, RoutedEventArgs e)
        {
            if (pass_txt.Text.Equals(""))
                pass_txt.Text = "Password:";
        }

        void email_txt_LostFocus(object sender, RoutedEventArgs e)
        {
            if (email_txt.Text.Equals(""))
                email_txt.Text = "Email:";
        }

        void phone_txt_LostFocus(object sender, RoutedEventArgs e)
        {
            if (phone_txt.Text.Equals(""))
                phone_txt.Text = "Phone:";
        }

        void fName_txt_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e) { }

        void lName_txt_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e) { }

        void age_txt_TextChanged  (object sender, System.Windows.Controls.TextChangedEventArgs e) { }

        void login_txt_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e) { }

        void pass_txt_TextChanged (object sender, System.Windows.Controls.TextChangedEventArgs e) { }

        void phone_txt_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e) { }

        void email_txt_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e) { }
    }
}
