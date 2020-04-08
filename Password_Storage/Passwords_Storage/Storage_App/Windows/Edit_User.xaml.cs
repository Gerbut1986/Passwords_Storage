using Storage_App.Models;
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

namespace Storage_App.Windows
{
    public partial class Edit_User : Window
    {
        User user;
        public Edit_User(User user)
        {
            InitializeComponent();
            this.user = user;
            fNameTxt.Text = user.First_Name;
            lNameTxt.Text = user.Last_Name;
            loginTxt.Text = user.Login;
            passTxt.Text = user.Password;
            roleTxt.Text = user.Role;
            ageTxt.Text = user.Age;
        }

        private void saveBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                My_Context db = new My_Context();

                // Get index from Item to ListBox:
                int index = (this.Owner as Show_Users).list.Items.IndexOf(this.user);

                // Get Id entity from the Table:
                int id = user.Id;

                // Get entity from DbSet to Id and edit it:
                List<User> all = ReadFromDatabase.Read_All_Users();
                User updated = all.Where(u => u.Id == id).FirstOrDefault();
                updated.First_Name = fNameTxt.Text;
                updated.Last_Name = lNameTxt.Text;
                updated.Login = loginTxt.Text;
                updated.Password = passTxt.Text;
                updated.Role = roleTxt.Text;
                updated.Age = ageTxt.Text;
                updated.Date_Register = DateTime.Now;
             
                // Update to Database:
                db.Entry(updated).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                (this.Owner as Show_Users).list.Items.RemoveAt(index);
                (this.Owner as Show_Users).list.Items.Insert(index, updated);

                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "System Exception..Failed..", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
