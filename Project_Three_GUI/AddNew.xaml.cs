using Project_Three_GUI.Classes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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
using System.Windows.Shapes;

namespace Project_Three_GUI
{
    /// <summary>
    /// Interaction logic for AddNew.xaml
    /// </summary>
    public partial class AddNew : Window
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conResident"].ConnectionString);
        StudentWorker sw = new StudentWorker();
        public AddNew()
        {
            InitializeComponent();
            AddResidentTypes();
            btnAdd.Visibility = Visibility.Hidden;
            HoursWorked.Visibility = Visibility.Hidden;
            HoursWorkedLab.Visibility = Visibility.Hidden;
            FloorID.IsEnabled = false;
            DormID.IsEnabled = false;
            
        }

        private void FirstName_TextChanged(object sender, TextChangedEventArgs e)
        {
            string firstName;
            firstName = FirstName.Text;

        }

        private void LastName_TextChanged(object sender, TextChangedEventArgs e)
        {
            string lastName;
            lastName = LastName.Text;

        }

        public void AddResidentTypes()
        {
            ResidentTypeName.Items.Add("");
            ResidentTypeName.Items.Add("Scholarship Recipient");
            ResidentTypeName.Items.Add("Student Athlete");
            ResidentTypeName.Items.Add("Student Worker");
        }
        
        public void AddFloors()
        {
            FloorID.Items.Clear();
            FloorID.IsEnabled = true;
            FloorID.Items.Add("");
            if (ResidentTypeName.SelectedItem.ToString() == "Student Worker")
            {
                FloorID.Items.Add("1");
                FloorID.Items.Add("2");
                FloorID.Items.Add("3");
            }
            else if (ResidentTypeName.SelectedItem.ToString() == "Student Athlete")
            {
                FloorID.Items.Add("4");
                FloorID.Items.Add("5");
                FloorID.Items.Add("6");
            }
            else if (ResidentTypeName.SelectedItem.ToString() == "Scholarship Recipient")
            {
                FloorID.Items.Add("7");
                FloorID.Items.Add("8");
            }
        }
        public void AddRooms()
        {
            
            DormID.IsEnabled = true;
            if (FloorID.SelectedItem.ToString() == "1")
            {
                DormID.Items.Add("101");
                DormID.Items.Add("102");
                DormID.Items.Add("103");
                DormID.Items.Add("104");
                DormID.Items.Add("105");
                DormID.Items.Add("106");
                DormID.Items.Add("107");
                DormID.Items.Add("108");
            }
            else if (FloorID.SelectedItem.ToString() == "2")
            {
                DormID.Items.Add("201");
                DormID.Items.Add("202");
                DormID.Items.Add("203");
                DormID.Items.Add("204");
                DormID.Items.Add("205");
                DormID.Items.Add("206");
                DormID.Items.Add("207");
                DormID.Items.Add("208");
            }
            else if (FloorID.SelectedItem.ToString() == "3")
            {
                DormID.Items.Add("301");
                DormID.Items.Add("302");
                DormID.Items.Add("303");
                DormID.Items.Add("304");
                DormID.Items.Add("305");
                DormID.Items.Add("306");
                DormID.Items.Add("307");
                DormID.Items.Add("308");
            }
            else if (FloorID.SelectedItem.ToString() == "4")
            {
                DormID.Items.Add("401");
                DormID.Items.Add("402");
                DormID.Items.Add("403");
                DormID.Items.Add("404");
                DormID.Items.Add("405");
                DormID.Items.Add("406");
                DormID.Items.Add("407");
                DormID.Items.Add("408");

            }
            else if (FloorID.SelectedItem.ToString() == "5")
            {
                DormID.Items.Add("501");
                DormID.Items.Add("502");
                DormID.Items.Add("503");
                DormID.Items.Add("504");
                DormID.Items.Add("505");
                DormID.Items.Add("506");
                DormID.Items.Add("507");
                DormID.Items.Add("508");
            }
            else if (FloorID.SelectedItem.ToString() == "6")
            {
                DormID.Items.Add("601");
                DormID.Items.Add("602");
                DormID.Items.Add("603");
                DormID.Items.Add("604");
                DormID.Items.Add("605");
                DormID.Items.Add("606");
                DormID.Items.Add("607");
                DormID.Items.Add("608");
            }
            else if (FloorID.SelectedItem.ToString() == "7")
            {
                
                DormID.Items.Add("701");
                DormID.Items.Add("702");
                DormID.Items.Add("703");
                DormID.Items.Add("704");
                DormID.Items.Add("705");
                DormID.Items.Add("706");
                DormID.Items.Add("707");
                DormID.Items.Add("708");
            }
            else if (FloorID.SelectedItem.ToString() == "8")
            {
                DormID.Items.Add("801");
                DormID.Items.Add("802");
                DormID.Items.Add("803");
                DormID.Items.Add("804");
                DormID.Items.Add("805");
                DormID.Items.Add("806");
                DormID.Items.Add("807");
                DormID.Items.Add("808");
            }
        }
        private void ResidentTypeName_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            AddFloors();
            btnAdd.Visibility = Visibility.Hidden;
            if (ResidentTypeName.SelectedItem.ToString() == "Student Worker")
            {
                HoursWorked.Visibility = Visibility.Visible;
                HoursWorkedLab.Visibility = Visibility.Visible;
            }
            else if (ResidentTypeName.SelectedItem.ToString() == "Student Athlete")
            {
                double totalRent;
                totalRent = 1200.00;

                StudentAthlete sa = new StudentAthlete()
                {
                    TotalRent = Convert.ToDouble(totalRent)
                };
                TotalRent.Text = ("$" + totalRent.ToString());

                HoursWorked.Visibility = Visibility.Hidden;
                HoursWorkedLab.Visibility = Visibility.Hidden;
            }
            else if (ResidentTypeName.SelectedItem.ToString() == "Scholarship Recipient")
            {
                double totalRent;
                totalRent = 100.00;

                ScholarshipRecipient sr = new ScholarshipRecipient()
                {
                    TotalRent = Convert.ToDouble(totalRent)
                };
                TotalRent.Text = ("$" + totalRent.ToString());

                HoursWorked.Visibility = Visibility.Hidden;
                HoursWorkedLab.Visibility = Visibility.Hidden;
            }
        }
        private void FloorID_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            AddRooms();
        }
        private void DormID_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ResidentTypeName.SelectedItem.ToString() != "StudentWorker")
            {
                if (FirstName.Text != null && LastName.Text != null && ResidentTypeName.SelectedItem != null && 
                    FloorID.SelectedItem != null && DormID.SelectedItem != null && HoursWorked.Text != null)
                {
                    btnAdd.Visibility = Visibility.Visible;
                }
                    
            }            
        }
        
        private void HoursWorked_TextChanged(object sender, TextChangedEventArgs e)
        {              
            string hoursWorked;
            hoursWorked = HoursWorked.Text;
            double totalRent;
            totalRent = 1245.00 - 14.00 * Convert.ToDouble(hoursWorked) / 2;
            
            StudentWorker sw = new StudentWorker()
            {
                HoursWorked = Convert.ToDouble(hoursWorked),
                TotalRent = Convert.ToDouble(totalRent)
            };
            TotalRent.Text = ("$" + totalRent.ToString());

            if (FirstName.Text != null && LastName.Text != null && ResidentTypeName.SelectedItem != null && 
                FloorID.SelectedItem != null && DormID.SelectedItem != null && HoursWorked.Text != null)
            {
                btnAdd.Visibility = Visibility.Visible;
            }
            else
            {
                btnAdd.Visibility = Visibility.Hidden;
            }
        }              
        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            
            try
            {
                

                string conResident = ConfigurationManager.ConnectionStrings["conResident"].ConnectionString;
                string addQuery = "INSERT into Residents(FirstName,LastName,ResidentTypeName,FloorID,DormID,HoursWorked,TotalRent) VALUES('"
                    + FirstName.Text + "','" + LastName.Text + "','" + ResidentTypeName.Text + "','" + FloorID.Text + "','" + DormID.Text +
                    "','" + HoursWorked.Text + "','" + TotalRent.Text + "');";
                SqlConnection addConn = new SqlConnection(conResident);
                SqlCommand addCmd = new SqlCommand(addQuery, addConn);
                SqlDataReader addReader;
                addConn.Open();
                addReader = addCmd.ExecuteReader();
                MessageBox.Show("Data saved");
                while (addReader.Read())
                {

                }
                addConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            AddNew Add = new AddNew();
            Add.Show();
            Close();
        }
        private void BtnGoBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow dashboard = new MainWindow();
            dashboard.Show();
            Close();
        }
        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
