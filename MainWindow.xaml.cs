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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CashModule
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        System.Windows.Threading.DispatcherTimer Timer = new System.Windows.Threading.DispatcherTimer();//start time or dashboard
        public MainWindow()
        {
            InitializeComponent();
            Timer.Tick += new EventHandler(ClockDash);
            Timer.Interval = new TimeSpan(0, 0, 1);
            Timer.Start();
            date.Text = DateTime.Now.ToString("dddd, dd/MM");
        }

        private void ClockDash(object sender, EventArgs e)
        {
            DateTime d;
            d = DateTime.Now;
            clock.Text = d.ToString("HH:mm:ss");
        }

        private void withdraw_Click(object sender, RoutedEventArgs e)
        {

        }

        private void deposit_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
