using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Threading;

namespace WpfApp8
{
    public partial class MainWindow : Window
    {
        private DispatcherTimer dispatcherTimer;
        private int x_seconds_external = 13;
        private int interval = 5;

        public MainWindow()
        {

            InitializeComponent();
            dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = TimeSpan.FromSeconds(1);
            dispatcherTimer.Start();
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            Timer();

            switch (x_seconds_external)
            {
                case 12:
                    Red.Fill = Brushes.Red;
                    break;
                case 7:
                    Red.Fill = Brushes.Red;
                    Yellow.Fill = Brushes.Yellow;
                    break;
                case 6:
                    Green.Fill = Brushes.Green;
                    Yellow.Fill = new SolidColorBrush(Color.FromRgb(46, 45, 33));
                    Red.Fill = new SolidColorBrush(Color.FromRgb(46, 45, 33));
                    break;
                case 1:
                    Red.Fill = new SolidColorBrush(Color.FromRgb(46, 45, 33));
                    Yellow.Fill = Brushes.Yellow;
                    Green.Fill = new SolidColorBrush(Color.FromRgb(46, 45, 33));
                    break;
                case 0:
                    Yellow.Fill = new SolidColorBrush(Color.FromRgb(46, 45, 33));
                    Red.Fill = Brushes.Red;
                    x_seconds_external = 12;
                    break;
            }

        }
        private void Timer()
        {
            //label1.Content = String.Format("{0}", interval);
            x_seconds_external--;
            if (interval > 0)
            {
                interval--;
            }
            else
            {
                label1.Content = null;
            }
        }
    }
}


