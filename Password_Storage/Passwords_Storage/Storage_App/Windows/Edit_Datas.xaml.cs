namespace Storage_App.Windows
{
    using System;
    using System.Linq;
    using System.Windows;
    using Storage_App.Models;
    using System.Collections.Generic;

    public partial class Edit_Datas : Window
    {
        Work_Area selectedDatas;
        int uniq_numb;
        public Edit_Datas(Work_Area selectedDatas, int uniq_numb)
        {
            InitializeComponent();
            this.uniq_numb = uniq_numb;
            this.selectedDatas = selectedDatas;
            nameTxt.Text = this.selectedDatas.Site_Name;
            emailTxt.Text = this.selectedDatas.Email;
            loginTxt.Text = this.selectedDatas.Login;
            passTxt.Text = this.selectedDatas.Password;
            urlTxt.Text = this.selectedDatas.URL;
            phoneTxt.Text = this.selectedDatas.Phone;
            commentTxt.Text = this.selectedDatas.Comments;
            createdTxt.Text = this.selectedDatas.DateCreated.ToString();
        }

        private void editBtn_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                My_Context db = new My_Context();

                // Get index from Item to ListBox:
                int index = (this.Owner as Show_Infos).list.Items.IndexOf(this.selectedDatas);

                // Get Id entity from the Table:
                int id = selectedDatas.Id;

                // Get entity from DbSet to Id and edit it:
                List<Work_Area> all = ReadFromDatabase.Read_All_Infos(uniq_numb);
                Work_Area updated = all.Where(u => u.Id == id).FirstOrDefault();
                updated.Site_Name = nameTxt.Text;
                updated.Email = emailTxt.Text;
                updated.Login = loginTxt.Text;
                updated.Password = passTxt.Text;
                updated.URL = urlTxt.Text;
                updated.Phone = phoneTxt.Text;
                updated.Comments = commentTxt.Text;
                updated.DateCreated = DateTime.Now;

                // Update to Database:
                //db.Entry(updated).State = System.Data.Entity.EntityState.Modified;
                //db.SaveChanges();

                string msg = new Edit_WorkArea().Update(updated, uniq_numb);

                // Insert to ListBox:
                (this.Owner as Show_Infos).list.Items.RemoveAt(index);
                (this.Owner as Show_Infos).list.Items.Insert(index, updated);

                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "System Exception..Failed..", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
