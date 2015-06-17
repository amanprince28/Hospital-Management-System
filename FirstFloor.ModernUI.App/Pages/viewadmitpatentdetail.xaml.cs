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
    /// Interaction logic for viewadmitpatentdetail.xaml
    /// </summary>
    public partial class viewadmitpatentdetail : UserControl
    {
        SqlConnection cn;
        SqlDataAdapter da;
        DataSet ds;
        public viewadmitpatentdetail()
        {
            InitializeComponent();
            admitpatientid();
            cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
           

        }

        void admitpatientid()
        {
            try
            {
                SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");

                con1.Open();
                string query = "select * from AdmitPatient";
                SqlCommand com = new SqlCommand(query, con1);
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    string Full_Name = dr.GetString(1);
                    comboadmitpatientid.Items.Add(Full_Name);
                } 
                con1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            cn.Open();
            da = new SqlDataAdapter("select * from AdmitPatient where Patient_ID ='"+comboadmitpatientid.Text+"' ", cn);
            ds = new DataSet();
            da.Fill(ds);
            datagrid4.ItemsSource = ds.Tables[0].DefaultView;
            cn.Close();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            cn.Open();
            da = new SqlDataAdapter("select * from AdmitPatient", cn);
            ds = new DataSet();
            da.Fill(ds);
            datagrid4.ItemsSource = ds.Tables[0].DefaultView;
            cn.Close();

        }

        


    }
}
