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
using System.IO;

namespace ModernUINavigationApp3.Pages
{
    /// <summary>
    /// Interaction logic for RemoveAdmin.xaml
    /// </summary>
    public partial class RemoveAdmin : UserControl
    {
        public RemoveAdmin()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
                con.Open();
                SqlCommand del = new SqlCommand("delete from Admin where Registration_Id='" + this.txtRegistrationid.Text + "'", con);
                del.ExecuteNonQuery();
                MessageBox.Show("Admin Removed");
                con.Close();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.ToString(),"Error");
            }
        }
    }
}
