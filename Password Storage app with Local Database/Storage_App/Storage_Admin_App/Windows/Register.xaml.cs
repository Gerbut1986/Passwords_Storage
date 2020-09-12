using Storage_Admin_App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Storage_Admin_App.Windows
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
        }

        private void text_btn_Click(object sender, RoutedEventArgs e)
        {
            AddUser();
        }

        void AddUser()
        {
            if (name_txt.Text == null && login_txt.Text == null && paswd_txt.Text == null && email_txt.Text == null &&
               phone_txt.Text == null && url_txt.Text == null && coments_txt.Text == null)
            {
                MessageBox.Show("All fields is empty", "empty", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else if (name_txt.Text == null || login_txt.Text == null || paswd_txt.Text == null || email_txt.Text == null ||
                phone_txt.Text == null || url_txt.Text == null || coments_txt.Text == null)
            {
                MessageBox.Show("Some of field are empty", "empty", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                User add_wa = new User
                {
                    SiteName = name_txt.Text,
                    Login = login_txt.Text,
                    Password = paswd_txt.Text,
                    Email = email_txt.Text,
                    Phone = System.Convert.ToInt32(phone_txt.Text),
                    URL = url_txt.Text,
                    Coments = coments_txt.Text,
                    DateCreate = DateTime.Now

                };

                db.WorkAreas.Add(add_wa);
                db.SaveChanges();
                MessageBox.Show($"SiteName-{name_txt.Text} was add sucsesfule");
                name_txt.Text = login_txt.Text = paswd_txt.Text = email_txt.Text = url_txt.Text = coments_txt.Text = phone_txt.Text = "";

            