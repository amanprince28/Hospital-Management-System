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

namespace FirstFloor.ModernUI.App.Pages
{
    /// <summary>
    /// Interaction logic for viewallappointment.xaml
    /// </summary>
    public partial class viewallappointment : UserControl
    {
        SqlConnection cn;
        SqlDataAdapter da;
        DataSet ds;
        public viewallappointment()
        {
            InitializeComponent();
            cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");

            cn.Open();
            FillData();
            //da = new SqlDataAdapter("select * from Appointment", cn);
            //ds = new DataSet();
            //da.Fill(ds);
            //DataGrid3.ItemsSource = ds.Tables[0].DefaultView;
            //cn.Close();

        }

        private void FillData()
        {
            da = new SqlDataAdapter("select * from Appointment", cn);
            ds = new DataSet();

            da.Fill(ds);
            DataGrid3.ItemsSource = ds.Tables[0].DefaultView;

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            da = new SqlDataAdapter("select * from Appointment", cn);
            ds = new DataSet();

            da.Fill(ds);
            DataGrid3.ItemsSource = ds.Tables[0].DefaultView;

            //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
            
            //string query = "select * from Appointment";
            //SqlCommand com = new SqlCommand(query, con);
            //SqlDataAdapter sda = new SqlDataAdapter(com);
            //DataTable dt = new DataTable("Appointment");
            //sda.Fill(dt);
            //DataGrid3.ItemsSource = dt.DefaultView;

            //cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");

            //cn.Open();
            //da = new SqlDataAdapter("select * from Appointment", cn);
            //ds = new DataSet();
            //da.Fill(ds);
            //DataGrid3.ItemsSource = ds.Tables[0].DefaultView;
            //cn.Close();
        }

        private void delbutton_Click(object sender, RoutedEventArgs e)
        {
            if (DataGrid3.SelectedItem != null)
            {
                ((DataRowView)(DataGrid3.SelectedItem)).Row.Delete();

                
            }
        }
    }
}
