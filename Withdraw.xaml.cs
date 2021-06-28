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
    /// Interaction logic for Withdraw.xaml
    /// </summary>
    public partial class Withdraw : Page
    {
        public Withdraw()
        {
            InitializeComponent();
        }

        private void depositbtn1_Click(object sender, RoutedEventArgs e)
        {
            string str = depsum1.Text.Trim();
            int check;
            bool ch = int.TryParse(str, out check);
            if (ch)
            {
                completedbar1.MessageQueue?.Enqueue("Выполнено!", null, null, null, false, true, TimeSpan.FromSeconds(1));
            }
            else if (depsum1.Text == string.Empty)
            {
                invalid1.MessageQueue?.Enqueue("Пустое поле", null, null, null, false, true, TimeSpan.FromSeconds(1));
            }
            else
            {
                invalid1.MessageQueue?.Enqueue("Введите сумму!", null, null, null, false, true, TimeSpan.FromSeconds(1));
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            depsum1.Clear();
            invalid1.MessageQueue?.Enqueue("Операция отменена!", null, null, null, false, true, TimeSpan.FromSeconds(1));
        }
    }
}
