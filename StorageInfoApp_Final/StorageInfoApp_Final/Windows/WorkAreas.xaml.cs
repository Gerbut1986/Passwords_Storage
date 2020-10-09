namespace StorageInfoApp_Final.Windows
{
    using System;
    using System.Linq;
    using System.Windows;
    using System.Windows.Media;
    using System.Windows.Threading;
    using StorageInfoApp_Final.DAO;
    using System.Collections.Generic;
    using StorageInfoApp_Final.Models;

    public partial class WorkAreas : Window
    {
        MyContext db = new MyContext();
        DispatcherTimer timer = null;
        int num_table;
        string role, user_name;
        public int time_end;
        MainWindow owner;
        Random rand = new Random();

        public WorkAreas(int num_table, string role, string user_name, MainWindow main)
        {
            InitializeComponent();
            owner = main;
            timer = new DispatcherTimer();  // если надо, то в скобках указываем приоритет, например DispatcherPriority.Render
            timer.Tick += Timer_Tick;
            timer.Interval = new TimeSpan(0, 0, 0, 0, 1000);
            timer.Start();
            time_end = 1;
            this.num_table = num_table;
            this.role = role;
            this.user_name = user_name;
            welcome_lbl.Content = $"Welcome - {user_name}";
            if (role.Equals("user"))
            {
                users_btn.Visibility = Visibility.Hidden;
                lbox.Height = 397;
            }
        }

        SolidColorBrush[] GetColor()
        {
            SolidColorBrush[] b = new SolidColorBrush[]
            {
                Brushes.Blue,
                Brushes.Maroon,
                Brushes.Yellow,
                Brushes.Magenta,
                Brushes.BurlyWood,
                Brushes.MediumAquamarine
            };
            return b;
        }

        void Timer_Tick(object sender, EventArgs e)
        {
            time_end++;
            //this.Title = time_end.ToString();
            //this.Background = GetColor()[rand.Next(1, 6)];
            if (time_end == 60)
            {
                time_end = 0;
                MessageBoxResult res = MessageBox.Show("Are you still here?", "End Session?", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (res == MessageBoxResult.Yes)
                {
                    timer.Tick += Timer_Tick;
                    time_end = 0;
                    return;
                }
                else // NO
                {
                    (this.owner as MainWindow).login_txt.Text = "Username:";
                    (this.owner as MainWindow).passwd_txt.Password = "Password:";
                    (this.owner as MainWindow).remeber_check.IsChecked = false;
                    // (this.owner as MainWindow).flag = false;
                    time_end = 0;
                    timer.Stop();
                    this.Close();
                }
            }
        }

        void add_btn_Click(object sender, RoutedEventArgs e)
        {
            lbox.Items.Clear();
            Create c = new Create("Add", num_table, this);
            c.Owner = this;
            c.ShowDialog();
        }

        void edit_btn_Click(object sender, RoutedEventArgs e)
        {
            if (lbox.SelectedItem != null)
            {
                WorkArea selected = lbox.SelectedItem as WorkArea;
                if (selected == null) return;
                else
                {
                    Create crate = new Create("Edit", selected, num_table);
                    crate.Owner = this;
                    crate.ShowDialog();
                }
            }
            else
                MessageBox.Show("First you need to sellect any object!", "NOT Selected", 
                    MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        void delete_btn_Click(object sender, RoutedEventArgs e)
        { 
            if(lbox.Items.Contains("The table is empty. Try to add new info"))
            {
                MessageBox.Show("You can't delete this text!", "..error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (lbox.SelectedItem != null)
            {
                MessageBoxResult res = MessageBox.Show("Are you realy want to delete this info??", "Delete?",
                    MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (res == MessageBoxResult.Yes)
                {
                    WorkArea del = lbox.SelectedItem as WorkArea;
                    DeleteLogic.DeleteInfo(del, num_table);
                    lbox.Items.Remove(lbox.SelectedItem);
                    if (lbox.Items.Count == 0)
                        lbox.Items.Add("The table is empty. Try to add new info");
                }
                else return;
            }
            else
                MessageBox.Show("First you need to sellect any object!", 
                    "NOT Selected", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        void users_btn_Click(object sender, RoutedEventArgs e)
        {
            UsersInfo edit_user = new UsersInfo(user_name);
            edit_user.Owner = this;
            edit_user.ShowDialog();
        }

        public void RefreshList()
        {
            var all_user = ReadFromDatabase.ShowAllUsers();
            User curr_user = all_user.FirstOrDefault(f => f.Id_WorkArea == num_table);
            welcome_lbl.Content = $"Welcome - {curr_user.First_Name} {curr_user.Last_Name}";
            int size = ReadFromDatabase.ShowAllAreas(num_table).Count();
            List<WorkArea> lArea = ReadFromDatabase.ShowAllAreas(num_table).ToList();
            for (int i = 0; i < size; i++)
                lbox.Items.Add(lArea[i]);

            if (lbox.Items.Count == 0) 
                lbox.Items.Add("The table is empty. Try to add new info");
        }

        public void Window_Loaded(object sender, RoutedEventArgs e) => RefreshList();

        //void Load_Closing(object sender, System.ComponentModel.CancelEventArgs e) => timer.Stop();

        void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            timer.Stop();
        }

        void Window_MouseMove(object sender, System.Windows.Input.MouseEventArgs e) => time_end = 0;
    }
}
