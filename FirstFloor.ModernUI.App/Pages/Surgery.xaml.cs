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
    /// Interaction logic for Surgery.xaml
    /// </summary>
    public partial class Surgery : UserControl
    {
        public Surgery()
        {
            InitializeComponent();
        }

        private void ModernButton_Click(object sender, RoutedEventArgs e)
        {
            if((txtPatientName.Text !="") || (txtPatientID.Text != "") || (txtDN_HODS.Text !="") || (txtDID_HODS.Text !="") || (txtAssistantSurgeon.Text !="") || (txtNursesName.Text !="") )
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
                    con.Open();
                    string insertQuery = "insert into SurgeryDetails (Patient_Name,Patient_Id,Doctor_Name,Doctors_ID,Assistant_Surgeons,Nurses_Names,Surgery_Date) values (@Patient_Name,@Patient_Id,@Doctor_Name,@Doctors_ID,@Assistant_Surgeons,@Nurses_Names,@Surgery_Date)";
                    SqlCommand com = new SqlCommand(insertQuery, con);

                    com.Parameters.AddWithValue("@Patient_Name", txtPatientName.Text);
                    com.Parameters.AddWithValue("@Patient_Id", txtPatientID.Text);
                    com.Parameters.AddWithValue("@Doctor_Name", txtDN_HODS.Text);
                    com.Parameters.AddWithValue("@Doctors_ID", txtDID_HODS.Text);
                    com.Parameters.AddWithValue("@Assistant_Surgeons", txtAssistantSurgeon.Text);
                    com.Parameters.AddWithValue("@Nurses_Names", txtNursesName.Text);
                    com.Parameters.AddWithValue("@Surgery_Date", SurgeryDate.Text);
                    
                    com.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Surgery Added");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString(), "Error");
                }
            }
            else
            {
                MessageBox.Show("Enter the Required Field");
            }

            
        }
    }
}
