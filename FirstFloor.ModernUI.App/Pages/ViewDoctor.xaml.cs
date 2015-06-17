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
using System.IO;


namespace ModernUINavigationApp3.Pages
{
    /// <summary>
    /// Interaction logic for ViewDoctor.xaml
    /// </summary>
    public partial class ViewDoctor : UserControl
    {
        SqlConnection cn;
        SqlDataAdapter da;
        DataSet ds;
        public ViewDoctor()
        {
            InitializeComponent();
            cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
            //cn.Open();
            FillData();
        
        }

        private void FillData()
        {
            cn.Open();
            da = new SqlDataAdapter("select * from Doctor",cn);
            ds = new DataSet();
            
            da.Fill(ds);
            DataGrid2.ItemsSource = ds.Tables[0].DefaultView;
            cn.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            cn.Open();
            da = new SqlDataAdapter("select * from Doctor", cn);
            ds = new DataSet();

            da.Fill(ds);
            DataGrid2.ItemsSource = ds.Tables[0].DefaultView;
            cn.Close();
        }

        private void delbutton_Click(object sender, RoutedEventArgs e)
        {
            if (DataGrid2.SelectedItem != null)
            {
                ((DataRowView)(DataGrid2.SelectedItem)).Row.Delete();
            }
        }

        
    }
}
