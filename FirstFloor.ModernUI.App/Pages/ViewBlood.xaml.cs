using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FirstFloor.ModernUI.App.Pages
{
    /// <summary>
    /// Interaction logic for ViewBlood.xaml
    /// </summary>
    public partial class ViewBlood : UserControl
    {
        SqlConnection cn;
        SqlDataAdapter da;
        DataSet ds;
        public ViewBlood()
        {
            InitializeComponent();
            cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
            FillData();
        }
        private void FillData()
        {
            cn.Open();
            da = new SqlDataAdapter("select * from Blood", cn);
            ds = new DataSet();

            da.Fill(ds);
            datagridblood.ItemsSource = ds.Tables[0].DefaultView;
            cn.Close();
        }

        
    }
}
