using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using System.Configuration;

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
            FillDataGrid();
        }
        private void FillDataGrid()
        {
            var ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            string CmdString = string.Empty;
            using (SqlConnection con = new SqlConnection(ConString))
            {
                CmdString = "SELECT resID, fName, lName, resType, floor, dormRm, hrsWorked, brdFee, FROM resTable";
                SqlCommand cmd = new SqlCommand(CmdString, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("resTable");
                sda.Fill(dt);
                dataGridViewAll.ItemsSource = dt.DefaultView;
            }
        }

        // RD selects Scholarship Recipients 
        private void Scholarship_Selected(object sender, RoutedEventArgs e)
        {
            // Scholarship Recipients may only reside on floors 7 and 8.

            // Scholarship Recipients pay a flat boarding fee of $100 monthly.
        }
        // RD selects Student Athletes
        private void Athlete_Selected(object sender, RoutedEventArgs e)
        {
            // Student athletes may only reside on floors 4 thru 6.

            // Student athletes pay a flat boarding fee of $1200 monthly.
        }
        // RD selects Student Workers
        private void Worker_Selected(object sender, RoutedEventArgs e)
        {
            // Student Workers may only reside on floors 1 thru 3.

            // Student Workers pay ($1245 - 0.5 * monthlyPay) for a boarding fee.
            // monthlyPay = $14.00 * hoursWorked
        }

        private void First_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Second_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Third_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Fourth_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Fifth_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Sixth_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Seventh_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Eighth_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Rm101_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Rm102_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Rm103_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Rm104_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Rm105_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Rm106_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Rm107_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Rm108_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Rm201_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Rm202_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Rm203_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Rm204_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Rm205_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Rm206_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Rm207_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Rm208_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Rm301_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Rm302_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Rm303_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Rm304_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Rm305_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Rm306_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Rm307_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Rm308_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Rm401_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Rm402_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Rm403_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Rm404_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Rm405_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Rm406_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Rm407_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Rm408_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Rm501_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Rm502_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Rm503_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Rm504_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Rm505_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Rm506_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Rm507_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Rm508_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Rm601_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Rm602_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Rm603_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Rm604_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Rm605_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Rm606_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Rm607_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Rm608_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Rm701_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Rm702_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Rm703_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Rm704_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Rm705_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Rm706_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Rm707_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Rm708_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Rm801_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Rm802_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Rm803_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Rm804_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Rm805_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Rm806_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Rm807_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Rm808_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void HoursWorked_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {

        }

        

    }
}
