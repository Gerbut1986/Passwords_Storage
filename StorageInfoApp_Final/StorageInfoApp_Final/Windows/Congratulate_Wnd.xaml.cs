namespace StorageInfoApp_Final.Windows
{
    using System.Windows;
    using System.Windows.Threading;

    public partial class Congratulate_Wnd : Window
    {
        DispatcherTimer timer = null;
        int timer_end = 0;

        public Congratulate_Wnd(string msg1, string msg2)
        {
            InitializeComponent();
            msg2_lbl.Content = msg1;
            msg3_lbl.Content = msg2;
            timer = new DispatcherTimer();  // если надо, то в скобках указываем приоритет, например DispatcherPriority.Render
            timer.Tick += Timer_Tick;
            timer.Interval = new System.TimeSpan(0, 0, 0, 0, 1000);
            timer.Start();
        }

        void Timer_Tick(object sender, System.EventArgs e)
        {
            timer_end++;
            if (timer_end == 2)
            {
                timer_end = 0;
                timer.Stop();
                this.Close();
            }
        }
    }
}
