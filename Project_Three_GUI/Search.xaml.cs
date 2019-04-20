using Project_Three_GUI.Classes;
using System;
using System.Collections.Generic;
using System.Configuration;
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
using System.Windows.Shapes;

namespace Project_Three_GUI
{
    /// <summary>
    /// Interaction logic for Search.xaml
    /// </summary>
    public partial class Search : Window
    {
        public Search()
        {
            InitializeComponent();
            AddResidentTypes();
            AddFloors();
            AddRooms();
            Resident objResToEdit = null;
            
        }
        private void ResidentID_TextChanged(object sender, TextChangedEventArgs e)
        {
            string conResident = ConfigurationManager.ConnectionStrings["conResident"].ConnectionString;
            string CmdString = string.Empty;
            using (SqlConnection con = new SqlConnection(conResident))
            {
                
                CmdString = "SELECT ResidentID, FirstName, LastName, ResidentTypeName, FloorID, DormID, TotalRent FROM Residents";
                if (ResidentID.Text != "")
                {
                    CmdString += " where ResidentID like '%" + ResidentID.Text + "%'";
                }
                SqlCommand cmd = new SqlCommand(CmdString, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("Residents");
                sda.Fill(dt);
                dataGridSearch.ItemsSource = dt.DefaultView;
            }
        }
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        private void ComboF_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string conResident = ConfigurationManager.ConnectionStrings["conResident"].ConnectionString;
            string CmdString = string.Empty;
            using (SqlConnection con = new SqlConnection(conResident))
            {

                CmdString = "SELECT ResidentID, FirstName, LastName, ResidentTypeName, FloorID, DormID, TotalRent FROM Residents";
                if (ComboF.SelectedItem.ToString() != "")
                {
                    CmdString += " where FloorID like '%" + ComboF.SelectedItem + "%'";
                    SqlCommand cmd = new SqlCommand(CmdString, con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable("Residents");
                    sda.Fill(dt);
                    dataGridSearch.ItemsSource = dt.DefaultView;
                }
                else
                {
                    dataGridSearch.ItemsSource = null;
                }

            }
        }
        private void ComboD_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string conResident = ConfigurationManager.ConnectionStrings["conResident"].ConnectionString;
            string CmdString = string.Empty;
            using (SqlConnection con = new SqlConnection(conResident))
            {

                CmdString = "SELECT ResidentID, FirstName, LastName, ResidentTypeName, FloorID, DormID, TotalRent FROM Residents";
                if (ComboD.SelectedItem.ToString() != "")
                {
                    CmdString += " where DormID like '%" + ComboD.SelectedItem + "%'";
                    SqlCommand cmd = new SqlCommand(CmdString, con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable("Residents");
                    sda.Fill(dt);
                    dataGridSearch.ItemsSource = dt.DefaultView;
                }
                else
                {
                    dataGridSearch.ItemsSource = null;
                }

            }

        }
        private void ComboR_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string conResident = ConfigurationManager.ConnectionStrings["conResident"].ConnectionString;
            string CmdString = string.Empty;
            using (SqlConnection con = new SqlConnection(conResident))
            {

                CmdString = "SELECT ResidentID, FirstName, LastName, ResidentTypeName, FloorID, DormID, TotalRent FROM Residents";
                if (ComboR.SelectedItem.ToString() != "")
                {
                    CmdString += " where ResidentTypeName like '%" + ComboR.SelectedItem + "%'";
                    SqlCommand cmd = new SqlCommand(CmdString, con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable("Residents");
                    sda.Fill(dt);
                    dataGridSearch.ItemsSource = dt.DefaultView;
                }
                else
                {
                    dataGridSearch.ItemsSource = null;
                }
            }
        }

        public void AddResidentTypes()
        {
            ComboR.Items.Clear();
            ComboR.IsEnabled = true;
            {
                ComboR.Items.Add("");
                ComboR.Items.Add("Scholarship Recipient");
                ComboR.Items.Add("Student Athlete");
                ComboR.Items.Add("Student Worker");
            }
        }
        public void AddFloors()
        {
            ComboF.Items.Clear();
            ComboF.IsEnabled = true;
            
            {
                ComboF.Items.Add(""); 
                ComboF.Items.Add("1");
                ComboF.Items.Add("2");
                ComboF.Items.Add("3");
           
                ComboF.Items.Add("4");
                ComboF.Items.Add("5");
                ComboF.Items.Add("6");
            
                ComboF.Items.Add("7");
                ComboF.Items.Add("8");
            }
        }
        public void AddRooms()
        {
            ComboD.Items.Clear();
            ComboD.IsEnabled = true;
            
            {
                ComboD.Items.Add("");
                ComboD.Items.Add("101");
                ComboD.Items.Add("102");
                ComboD.Items.Add("103");
                ComboD.Items.Add("104");
                ComboD.Items.Add("105");
                ComboD.Items.Add("106");
                ComboD.Items.Add("107");
                ComboD.Items.Add("108");

                ComboD.Items.Add("201");
                ComboD.Items.Add("202");
                ComboD.Items.Add("203");
                ComboD.Items.Add("204");
                ComboD.Items.Add("205");
                ComboD.Items.Add("206");
                ComboD.Items.Add("207");
                ComboD.Items.Add("208");

                ComboD.Items.Add("301");
                ComboD.Items.Add("302");
                ComboD.Items.Add("303");
                ComboD.Items.Add("304");
                ComboD.Items.Add("305");
                ComboD.Items.Add("306");
                ComboD.Items.Add("307");
                ComboD.Items.Add("308");

                ComboD.Items.Add("401");
                ComboD.Items.Add("402");
                ComboD.Items.Add("403");
                ComboD.Items.Add("404");
                ComboD.Items.Add("405");
                ComboD.Items.Add("406");
                ComboD.Items.Add("407");
                ComboD.Items.Add("408");

                ComboD.Items.Add("501");
                ComboD.Items.Add("502");
                ComboD.Items.Add("503");
                ComboD.Items.Add("504");
                ComboD.Items.Add("505");
                ComboD.Items.Add("506");
                ComboD.Items.Add("507");
                ComboD.Items.Add("508");

                ComboD.Items.Add("601");
                ComboD.Items.Add("602");
                ComboD.Items.Add("603");
                ComboD.Items.Add("604");
                ComboD.Items.Add("605");
                ComboD.Items.Add("606");
                ComboD.Items.Add("607");
                ComboD.Items.Add("608");

                ComboD.Items.Add("701");
                ComboD.Items.Add("702");
                ComboD.Items.Add("703");
                ComboD.Items.Add("704");
                ComboD.Items.Add("705");
                ComboD.Items.Add("706");
                ComboD.Items.Add("707");
                ComboD.Items.Add("708");

                ComboD.Items.Add("801");
                ComboD.Items.Add("802");
                ComboD.Items.Add("803");
                ComboD.Items.Add("804");
                ComboD.Items.Add("805");
                ComboD.Items.Add("806");
                ComboD.Items.Add("807");
                ComboD.Items.Add("808");
            }
        }
        private void FillDataGrid()
        {
            string conResident = ConfigurationManager.ConnectionStrings["conResident"].ConnectionString;
            string CmdString = string.Empty;
            using (SqlConnection con = new SqlConnection(conResident))
            {
                CmdString = "SELECT ResidentID, FirstName, LastName, ResidentTypeName, FloorID, DormID, TotalRent FROM Residents";
                SqlCommand cmd = new SqlCommand(CmdString, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("Residents");
                sda.Fill(dt);
                dataGridSearch.ItemsSource = dt.DefaultView;
            }
        }
        private void BtnViewAll_Click(object sender, RoutedEventArgs e)
        {
            FillDataGrid();

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

        /*private void DataGridSearch_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            objResToEdit = dataGridSearch.SelectedItem as Resident;
        }
        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            string conResident = ConfigurationManager.ConnectionStrings["conResident"].ConnectionString;
            string DltString = string.Empty;

            SqlConnection sqlCon = new SqlConnection(conResident);
            if (objResToEdit == null)
            {
                MessageBox.Show("Cannot delete a blank entry, please select the row that you would like to delete.");
            
            }
            else
            {
                    sqlCon.Open();
                    DltString = "DELETE ResidentID, FirstName, LastName, ResidentTypeName, FloorID, DormID, HoursWorked, and TotalRent FROM Residents";
                    SqlCommand DltCmd = new SqlCommand(DltString, sqlCon);
                    SqlDataAdapter sda = new SqlDataAdapter(DltCmd);
                    DataTable dt = new DataTable("Residents");
                    sda.Fill(dt);
                    dataGridSearch.ItemsSource = dt.DefaultView;
                    sqlCon.Close();
                    MessageBox.Show("Row Deleted");
            }
        }*/
    }
}