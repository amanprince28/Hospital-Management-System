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
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ModernUINavigationApp3.Pages
{
    /// <summary>
    /// Interaction logic for ViewAdmin.xaml
    /// </summary>
    public partial class ViewAdmin : UserControl
    {
        public ViewAdmin()
        {
            InitializeComponent();
            FillDataGrid();

        }
        private void FillDataGrid()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
            string query = "select Full_Name,Registration_Id,User_Name,Contact_No,Email_Id from Admin";
            SqlCommand com = new SqlCommand(query,con);
            SqlDataAdapter sda = new SqlDataAdapter(com);
            DataTable dt = new DataTable("Admin");
            sda.Fill(dt);
            datagridviewadmin.ItemsSource = dt.DefaultView;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
            string query = "select Full_Name,Registration_Id,User_Name,Contact_No,Email_Id from Admin";
            SqlCommand com = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(com);
            DataTable dt = new DataTable("Admin");
            sda.Fill(dt);
            datagridviewadmin.ItemsSource = dt.DefaultView;
        }

        
        private void delbutton_Click(object sender, RoutedEventArgs e)
        {
            if (datagridviewadmin.SelectedItem != null)
            {
                ((DataRowView)(datagridviewadmin.SelectedItem)).Row.Delete();


            }

        }

       
    }
}
