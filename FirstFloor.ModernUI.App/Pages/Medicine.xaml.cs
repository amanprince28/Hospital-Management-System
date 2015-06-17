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
    /// Interaction logic for Medicine.xaml
    /// </summary>
    public partial class Medicine : UserControl
    {
        public Medicine()
        {
            InitializeComponent();
        }

        private void ModernButton_Click(object sender, RoutedEventArgs e)
        {
            if((txtMedicineName.Text != "") || (txtcompanyname.Text !=""))
            {
                try
                {
                    string mname = txtMedicineName.Text;
                    string cname = txtcompanyname.Text;

                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Insert into Medicine (Medicine_Name,Company_Name) values('" + mname + "','" + cname + "')", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Medicine added");
                }
                catch(SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    
                }
            }
            else
            {
                MessageBox.Show("Enter the Medicine & Company Name");
            }
        }
    }
}
