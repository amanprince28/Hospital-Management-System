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

namespace ModernUINavigationApp3.Pages
{
    /// <summary>
    /// Interaction logic for ViewEmployee.xaml
    /// </summary>
    public partial class ViewEmployee : UserControl
    {
        SqlConnection cn;
        SqlDataAdapter da;
        DataSet ds;
        public ViewEmployee()
        {
            InitializeComponent();
            cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
            cn.Open();
            FillData();
        }

        private void FillData()
        {
            da = new SqlDataAdapter("select * from Employee",cn);
            ds = new DataSet();
            da.Fill(ds);
            DataGridEmployee.ItemsSource = ds.Tables[0].DefaultView;
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            da = new SqlDataAdapter("select * from Employee", cn);
            ds = new DataSet();
            da.Fill(ds);
            DataGridEmployee.ItemsSource = ds.Tables[0].DefaultView;
        }
    }
}
