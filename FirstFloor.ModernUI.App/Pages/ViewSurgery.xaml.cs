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


namespace FirstFloor.ModernUI.App.Pages
{
    /// <summary>
    /// Interaction logic for ViewSurgery.xaml
    /// </summary>
    public partial class ViewSurgery : UserControl
    {
        SqlConnection cn;
        SqlDataAdapter da;
        DataSet ds;
        public ViewSurgery()
        {
            InitializeComponent();
            cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
            
        }

        private void ModernButton_Click(object sender, RoutedEventArgs e)
        {
            cn.Open();
            da = new SqlDataAdapter("select * from SurgeryDetails", cn);
            ds = new DataSet();

            da.Fill(ds);
            datagrid.ItemsSource = ds.Tables[0].DefaultView;
            cn.Close();
        }
    }
}
