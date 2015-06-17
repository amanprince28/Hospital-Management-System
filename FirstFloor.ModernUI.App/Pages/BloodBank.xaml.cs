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
    /// Interaction logic for BloodBank.xaml
    /// </summary>
    public partial class BloodBank : UserControl
    {
        public BloodBank()
        {
            InitializeComponent();
        }

        private void ModernButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string bloodgroup = comboBloodGroup.Text;
                string quantity = comboQuantity.Text;

                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into Blood (Blood_Group,Quantity) Values ('" + bloodgroup + "','" + quantity + "')",con);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show(" added");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        
    }
}
