namespace StorageInfoApp_Final.Windows
{
    using System.Linq;
    using System.Windows;
    using System.Windows.Input;
    using StorageInfoApp_Final.Models;

    public partial class UsersInfo : Window
    {
        User[] users;
        public UsersInfo() => InitializeComponent();

        void close_btn_Click(object sender, RoutedEventArgs e) => this.Close();

        void edit_btn_Click(object sender, RoutedEventArgs e)
        {
            if (list.SelectedItem != null) // Если мы что то выбрали с листбокса
            {
                User selected = list.SelectedItem as User;
                EditUser_Wnd edit_window = new EditUser_Wnd(selected);
                edit_window.Owner = this;
                edit_window.ShowDialog();
            }
            else
                MessageBox.Show("You don't selected nothing..", "..Not selected..",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        void del_btn_Click(object sender, RoutedEventArgs e)
        {
            if (list.SelectedItem != null)
            {
                MessageBoxResult res = MessageBox.Show("Are you realy want to delete this info??", "Delete?", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (res == MessageBoxResult.Yes)
                {
                    User del = list.SelectedItem as User;
                    DAO.DeleteLogic.DeleteUser(del);
                    list.Items.Remove(list.SelectedItem);
                    if (list.Items.Count == 0)
                        list.Items.Add("The table is empty. Try to add new info");
                }
                else return;
            }
            else
                MessageBox.Show("First you need to sellect any object!", "NOT Selected", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        public void RefreshList()
        {
            users = ReadFromDatabase.ShowAllUsers().ToArray();
            int size = users.Length;
            for (int i = 0; i < size; i++)
            {
                list.Items.Add(users[i]);
            }
            if (list.Items.Count == 0)
                list.Items.Add("The table is empty. Try to register new user!");
        }

        void loaded_Loaded(object sender, RoutedEventArgs e) => RefreshList();

        void loaded_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }
    }
}
