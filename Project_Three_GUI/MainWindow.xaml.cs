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

namespace Project_Three_GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

       

        // RD selects Student Workers
        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            // Scholarship Recipients may only reside on floors 1 thru 3.

            // Scholarship Recipients pay ($1245 - 0.5 * monthlyPay) for a boarding fee.
            // monthlyPay = $14.00 * hoursWorked
        }
        // RD selects Student Athletes
        private void ComboBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {
            // Scholarship Recipients may only reside on floors 4 thru 6.

            // Scholarship Recipients pay a flat boarding fee of $1200 monthly.
        }
        // RD selects Scholarship Recipients 
        private void ComboBoxItem_Selected_2(object sender, RoutedEventArgs e)
        {
            // Scholarship Recipients may only reside on floors 7 and 8.

            // Scholarship Recipients pay a flat boarding fee of $100 monthly.
        }
    }
}
