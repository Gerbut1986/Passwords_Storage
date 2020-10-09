namespace StorageInfoApp_Final.Windows
{
    using System.Linq;
    using System.Windows;
    using System.Windows.Input;
    using System.Collections.Generic;
    using StorageInfoApp_Final.Models;

    public partial class UserSession_Wnd : Window
    {
        User selectUser;
        public UserSession_Wnd(User selectUser)
        {
            InitializeComponent();
            this.selectUser = selectUser;
            first_text.Content = $"{selectUser.First_Name}  {selectUser.Last_Name}";

            List<UsersSessions> sessions = ReadFromDatabase.AllUsersSessions(selectUser.Id_WorkArea).ToList();
            if (sessions.Count == 0)
                sessions_list.Items.Add("You need to restart the application for the session to be created!");
            else
                foreach (var i in sessions)
                    sessions_list.Items.Add(i);
        }

        void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void close_btn_Click(object sender, RoutedEventArgs e) => this.Close();
    }
}
