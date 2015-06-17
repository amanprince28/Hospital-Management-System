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
    /// Interaction logic for viewappointment.xaml
    /// </summary>
    public partial class viewappointment : UserControl
    {
        SqlConnection cn;
        SqlDataAdapter da;
        DataSet ds;
        public viewappointment()
        {
            InitializeComponent();
            fillcomboboxdoctorname();

            cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");

        }

        

        private void fillcomboboxdoctorname()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
                con.Open();
                string query = "select * from Appointment";
                SqlCommand com = new SqlCommand(query, con);
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    string Doctors_Name = dr.GetString(2);
                    comboDoctorsName.Items.Add(Doctors_Name);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void comboDoctorsName_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            cn.Open();
            da = new SqlDataAdapter("select * from Appointment where Doctors_Name='" + comboDoctorsName.Text + "'", cn);
            ds = new DataSet();
            da.Fill(ds);
            DataGrid1.ItemsSource = ds.Tables[0].DefaultView;
            cn.Close();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            cn.Open();
            da = new SqlDataAdapter("select * from Appointment where Doctors_Name='" + comboDoctorsName.Text + "'", cn);
            ds = new DataSet();
            da.Fill(ds);
            DataGrid1.ItemsSource = ds.Tables[0].DefaultView;
            cn.Close();
        }

    }
}
