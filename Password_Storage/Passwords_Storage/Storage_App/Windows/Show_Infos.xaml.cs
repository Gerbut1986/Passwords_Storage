namespace Storage_App
{
    using System;
    using System.Windows;
    using Storage_App.Models;
    using Storage_App.Windows;

    public partial class Show_Infos : Window
    {
        int uniq_numb;
        public Show_Infos(string mode, int uniq_numb)
        {
            InitializeComponent();
            this.uniq_numb = uniq_numb;
            try
            {
                if (mode == "user") editBtn.Visibility = Visibility.Hidden;
                for (int i = 0; i < ReadFromDatabase.Read_All_Infos(uniq_numb).Count; i++)
                    list.Items.Add(ReadFromDatabase.Read_All_Infos(uniq_numb)[i]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System Exception..Failed..", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void editBtn_Click(object sender, RoutedEventArgs e)
        {
            if (list.SelectedItem != null) // Если мы что то выбрали с листбокса
            {
                Work_Area selected_recordt = list.SelectedItem as Work_Area;
                Edit_Datas editForm = new Edit_Datas(selected_recordt, uniq_numb);
                editForm.Owner = this;
                editForm.ShowDialog();
            }
            else
                MessageBox.Show("You don't selected nothing..", "..Not selected..",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
        }
    }
}
