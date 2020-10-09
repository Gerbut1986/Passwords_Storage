namespace StorageInfoApp_Final.Windows
{
    using System;
    using System.Linq;
    using System.Windows;
    using StorageInfoApp_Final.DAO;
    using System.Collections.Generic;
    using StorageInfoApp_Final.Models;

    public partial class Create : Window
    {
        MyContext db = new MyContext();
        WorkArea update_Area;
        WorkAreas owner = null;
        string mode;
        int num;

        public Create(string mode, int num, WorkAreas owner)      // Add
        {
            InitializeComponent();
            this.owner = owner;
            this.num = num;
            add_btn.Content = "Add New";
            this.mode = mode;
            text1_txt.Text = "Add New one Info";
            text2_txt.Text = "about your website";
        }

        public Create(string mode, WorkArea update_Area, int num) // Edit
        {
            InitializeComponent();

            text1_txt.Text = "Edit selected info";
            text2_txt.Text = "about your website";
            add_btn.Content = "Update";
            this.update_Area = update_Area;
            this.mode = mode;
            this.num = num;

            name_txt.Text = update_Area.SiteName;
            login_txt.Text = update_Area.Login;
            pass_txt.Text = update_Area.Password;
            email_txt.Text = update_Area.Email;
            phone_txt.Text = update_Area.Phone.ToString();
            url_txt.Text = update_Area.URL;
            comment_txt.Text = update_Area.Coments;
        }

        void EditArea()
        {
            int index = (this.Owner as WorkAreas).lbox.Items.IndexOf(this.update_Area);
            int idTable = update_Area.Id;

            List<WorkArea> all = ReadFromDatabase.ShowAllAreas(num).ToList();
            WorkArea update = all.Where(i => i.Id == idTable).FirstOrDefault();
            update.SiteName = name_txt.Text;
            update.Login = login_txt.Text;
            update.Password = pass_txt.Text;
            update.Phone = Convert.ToInt32(phone_txt.Text);
            update.URL = url_txt.Text;
            update.Email = email_txt.Text;
            update.Coments = comment_txt.Text;
            update.DateCreate = DateTime.Now;

            string res = EditLogic.EditInfo(update, num);

            new Congratulate_Wnd("Result Update",res).ShowDialog();

            (this.Owner as WorkAreas).lbox.Items.RemoveAt(index);
            (this.Owner as WorkAreas).lbox.Items.Insert(index, update);

            this.Close();
        }

        void Add_Info()
        {
            if (name_txt.Text == "Site Name:" && login_txt.Text == "URL:" && pass_txt.Text == "Login:" && email_txt.Text == "Password:" &&
               phone_txt.Text == "Phone:" && url_txt.Text == "Email:" && comment_txt.Text == "Comment:")
                MessageBox.Show("All fields is empty", "empty", MessageBoxButton.OK, MessageBoxImage.Warning);
            else
            {
                try
                {
                    WorkArea add_wa = new WorkArea
                    {
                        SiteName = name_txt.Text,
                        Login = login_txt.Text,
                        Password = pass_txt.Text,
                        Email = email_txt.Text,
                        URL = url_txt.Text,
                        Coments = comment_txt.Text,
                    };
                    try
                    {
                        add_wa.Phone = Convert.ToInt32(phone_txt.Text);
                    }
                    catch { MessageBox.Show("Phone should be a number value\nbut doesn't text", "Wrong format", MessageBoxButton.OK, MessageBoxImage.Warning); }

                    add_wa.DateCreate = DateTime.Now;
                    string msg = InsertLogic.AddWorkArea(add_wa, num);
                    new Congratulate_Wnd($"Info - {add_wa.SiteName}", "Has Add Successfuly!").ShowDialog();
                    var infos = ReadFromDatabase.ShowAllAreas(num).ToList();
                    WorkArea currentInfo = infos.Where(i => i.Id == infos.Count).FirstOrDefault();
                    owner.RefreshList();
                    name_txt.Text = login_txt.Text = pass_txt.Text = email_txt.Text = url_txt.Text = comment_txt.Text = phone_txt.Text = "";
                    this.Close();
                }
                catch { }
            }
        }

        void Window_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.LeftButton == System.Windows.Input.MouseButtonState.Pressed)
                DragMove();
        }

        void add_btn_Click(object sender, RoutedEventArgs e)
        {
            if (mode == "Add") Add_Info();
            else if (mode == "Edit") EditArea();
        }

        void name_txt_GotFocus(object sender, RoutedEventArgs e)
        {
            if (mode.Equals("Edit")) return;
            name_txt.Text = "";        
        }

        void url_txt_GotFocus(object sender, RoutedEventArgs e)
        {
            if (mode.Equals("Edit")) return;
            url_txt.Text = "";
        }

        void login_txt_GotFocus(object sender, RoutedEventArgs e)
        {
            if (mode.Equals("Edit")) return;
            login_txt.Text = "";
        }

        void pass_txt_GotFocus(object sender, RoutedEventArgs e)
        {
            if (mode.Equals("Edit")) return;
            pass_txt.Text = "";
        }

        void phone_txt_GotFocus(object sender, RoutedEventArgs e)
        {
            if (mode.Equals("Edit")) return;
            phone_txt.Text = "";
        }

        void email_txt_GotFocus(object sender, RoutedEventArgs e)
        {
            if (mode.Equals("Edit")) return;
            email_txt.Text = "";
        }

        void comment_txt_GotFocus(object sender, RoutedEventArgs e)
        {
            if (mode.Equals("Edit")) return;
            comment_txt.Text = "";
        }

        void name_txt_LostFocus(object sender, RoutedEventArgs e)
        {
            if (mode.Equals("Add"))
                if (name_txt.Text.Equals(""))
                    name_txt.Text = "Site Name:";
        }

        void url_txt_LostFocus(object sender, RoutedEventArgs e)
        {
            if (mode.Equals("Add"))
                if (url_txt.Text.Equals(""))
                    url_txt.Text = "URL:";
        }

        void login_txt_LostFocus(object sender, RoutedEventArgs e)
        {
            if (mode.Equals("Add"))
                if (login_txt.Text.Equals(""))
                    login_txt.Text = "Login:";
        }

        void pass_txt_LostFocus(object sender, RoutedEventArgs e)
        {
            if (mode.Equals("Add"))
                if (pass_txt.Text.Equals(""))
                pass_txt.Text = "Password:";
        }

        void email_txt_LostFocus(object sender, RoutedEventArgs e)
        {
            if (mode.Equals("Add"))
                if (email_txt.Text.Equals(""))
                email_txt.Text = "Email:";
        }

        void phone_txt_LostFocus(object sender, RoutedEventArgs e)
        {
            if (mode.Equals("Add"))
                if (phone_txt.Text.Equals(""))
                phone_txt.Text = "Phone:";
        }

        void comment_txt_LostFocus(object sender, RoutedEventArgs e)
        {
            if (mode.Equals("Add"))
                if (comment_txt.Text.Equals(""))
                comment_txt.Text = "Comment:";
        }

        void close_btn_Click(object sender, RoutedEventArgs e) => this.Close();

        void close_btn_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e) => Close();

        void Window_MouseMove(object sender, System.Windows.Input.MouseEventArgs e) { } //=> (this.owner as WorkAreas).time_end = 0;
    }
}
