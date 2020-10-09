namespace StorageInfoApp_Final.Windows
{
    using System.Linq;
    using System.Windows;
    using StorageInfoApp_Final.DAO;
    using System.Collections.Generic;
    using StorageInfoApp_Final.Models;

    public partial class EditUser_Wnd : Window
    {
        MyContext db = new MyContext();
        User user;
        public EditUser_Wnd(User user)
        {
            InitializeComponent();
            this.user = user;
            username_lbl.Text = "User - " + user.First_Name;
            fName_txt.Text = user.First_Name;
            lName_txt.Text = user.Last_Name;
            login_txt.Text = user.Login;
            pass_txt.Text = user.Password;
            phone_txt.Text = user.Phone;
            age_txt.Text = user.Age.ToString();
            email_txt.Text = user.Email;
        }

        void upd_btn_Click(object sender, RoutedEventArgs e)
        {
            int index = (this.Owner as UsersInfo).list.Items.IndexOf(this.user);
            int idTable = user.Id;

            List<User> all = ReadFromDatabase.ShowAllUsers().ToList();
            User update = all.Where(i => i.Id == idTable).FirstOrDefault();
            update.First_Name = fName_txt.Text;
            update.Last_Name = lName_txt.Text;
            update.Login = login_txt.Text;
            update.Password = pass_txt.Text;
            update.Phone = phone_txt.Text;
            update.Email = email_txt.Text;
            update.Age = System.Convert.ToInt32(age_txt.Text);

            string res = EditLogic.EditUser(update);

            new Congratulate_Wnd($"User - {update.First_Name}", "Has been Updated Successfully!").ShowDialog();

            (this.Owner as UsersInfo).list.Items.RemoveAt(index);
            (this.Owner as UsersInfo).list.Items.Insert(index, update);

            this.Close();
        }

        void fName_txt_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e) { }

        void lName_txt_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e) { }

        void age_txt_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e) { }

        void login_txt_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e) { }

        void pass_txt_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e) { }

        void phone_txt_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e) { }

        void email_txt_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e) { }

        void Window_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.LeftButton == System.Windows.Input.MouseButtonState.Pressed)
                DragMove();
        }

        void close_btn_Click(object sender, RoutedEventArgs e) => this.Close();
    }
}
