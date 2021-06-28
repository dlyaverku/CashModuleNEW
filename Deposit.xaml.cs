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
using System.Data.SqlClient;
using System.Data;

namespace CashModule
{
    /// <summary>
    /// Interaction logic for Deposit.xaml
    /// </summary>
    public partial class Deposit : Page
    {
        public Deposit()
        {
            InitializeComponent();
        }

        private void Depositbtn(object sender, RoutedEventArgs e)
        {

            string str = depsum.Text.Trim();
            int check;
            bool ch = int.TryParse(str, out check);
            if (ch)
            {
                completedbar.MessageQueue?.Enqueue("Выполнено!", null, null, null, false, true, TimeSpan.FromSeconds(1));
            }
            else if(depsum.Text == string.Empty)
            {
                invalid.MessageQueue?.Enqueue("Пустое поле", null, null, null, false, true, TimeSpan.FromSeconds(1));
            }
            else
            {
                invalid.MessageQueue?.Enqueue("Введите сумму!", null, null, null, false, true, TimeSpan.FromSeconds(1));
            }
            
        }
        

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        
           

    }
}
