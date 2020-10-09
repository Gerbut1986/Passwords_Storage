namespace StorageInfoApp_Final.Windows
{
    using System;
    using System.Linq;
    using System.Windows;
    using System.Windows.Input;
    using System.Windows.Threading;
    using StorageInfoApp_Final.Models;

    public partial class UsersInfo : Window
    {
        User[] users;
        DispatcherTimer timer;
        int time_shw_txt;

        public UsersInfo(string user_name)
        {
            InitializeComponent();

            timer = new DispatcherTimer();
            timer.Tick += Timer_Tick;
            timer.Interval = new TimeSpan(0, 0, 0, 0, 1000);
            timer.Start();
            time_shw_txt = 1;
        }

        void Timer_Tick(object sender, System.EventArgs e)
        {
            time_shw_txt++;
            if (time_shw_txt == 3)
            {
                time_shw_txt = 0;
                _1st_txt.Text = GetText()[new Random().Next(0, 2)];
            }
        }

        string[] GetText() =>
            new string[] { "Info about all register Users", "Select any user to see his sessions!" };

        void close_btn_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
            this.Close();
        }

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
                MessageBoxResult res = MessageBox.Show("Are you realy want to delete this info??", "Delete?", 
                    MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (res == MessageBoxResult.Yes)
                {
                    var allUsers = ReadFromDatabase.ShowAllUsers();
                    if (allUsers.Count() != 1)
                    {
                        User del = list.SelectedItem as User;
                        DAO.DeleteLogic.DeleteUser(del);
                        list.Items.Remove(list.SelectedItem);
                        if (list.Items.Count == 0)
                            list.Items.Add("The table is empty. Try to add new info");
                    }
                    else MessageBox.Show("There is only one user left ..\n it is not possible to delete it!", "One user",
                        MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else return;
            }
            else
                MessageBox.Show("First you need to sellect any object!", "NOT Selected",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
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

        void loaded_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        void list_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e) 
            => Selected_User(list.SelectedItem as User);

        void list_MouseDoubleClick(object sender, MouseButtonEventArgs e) => Selected_User(list.SelectedItem as User);

        void Selected_User(User selectedUser)
        {
            selectedUser = list.SelectedItem as User;
            MessageBoxResult res = MessageBox.Show($"Do you want to see {selectedUser.First_Name}" +
                $" UserSessions of a table (yes/no)?", "User Session", MessageBoxButton.YesNo, MessageBoxImage.Asterisk);
            if (res == MessageBoxResult.Yes)
            {
                UserSession_Wnd session = new UserSession_Wnd(selectedUser);
                session.ShowDialog();
            }
            else return;
        }

        void loaded_MouseMove(object sender, MouseEventArgs e) => (this.Owner as WorkAreas).time_end = 0;
    }
}
