using System;
using System.Collections.Generic;
using System.Configuration;
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
    /// Interaction logic for LoginScreen.xaml
    /// </summary>
    public partial class LoginScreen : Window
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conLogin"].ConnectionString);

            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                    conn.Open();
                string query = "SELECT COUNT(1) FROM tblUser WHERE Username=@Username AND Password=@Password";
                SqlCommand sqlCmd = new SqlCommand(query, conn)
                {
                    CommandType = System.Data.CommandType.Text
                };
                sqlCmd.Parameters.AddWithValue("@Username",txtUsername.Text);
                sqlCmd.Parameters.AddWithValue("@Password",txtPassword.Password);
                int count = Convert.ToInt32(sqlCmd.ExecuteScalar());
                if (count == 1)
                {
                    MainWindow dashboard = new MainWindow();
                    dashboard.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Username or password is incorrect.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
