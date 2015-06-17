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
using System.Speech.Synthesis;

namespace ModernUINavigationApp3.Pages
{
    /// <summary>
    /// Interaction logic for EyeAppointment.xaml
    /// </summary>
    public partial class EyeAppointment : UserControl
    {
        SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
        
        public EyeAppointment()
        {
            InitializeComponent();
            doctornamecombo();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");

        void doctornamecombo()
        {
            try
            {
                con.Open();
                string query = "select * from Doctor where Specialization = 'Eye'";
                SqlCommand com = new SqlCommand(query,con);
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    string Full_Name = dr.GetString(0);
                    comboDoctorName.Items.Add(Full_Name);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Submitbutton_Click(object sender, RoutedEventArgs e)
        {
            if((txtFullName.Text != "") || (txtGurdianName.Text != "") || (comboDoctorName.Text != "") || (comboboxGender.Text != "") || (txtContactNo.Text != "") || (txtAddress.Text != "") )
            {
                try
                {
                    string pname = txtFullName.Text;
                    string gname = txtGurdianName.Text;
                    string dname = comboDoctorName.Text;
                    string gen = comboboxGender.Text;
                    string app = AppointmentDate.Text;
                    string con = txtContactNo.Text;
                    string add = txtAddress.Text;

                    SqlConnection con2 = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
                    con2.Open();
                    SqlCommand cmd = new SqlCommand("Insert into Appointment (Patient_Name,Gurdian_Name,Doctors_Name,Gender,Appointment_Date,Contact_No,Address) values('" + pname + "','" + gname + "','" + dname + "','" + gen+ "','" + app + "','" + con + "','"+add+"')", con2);

                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    con2.Close();

                    speechSynthesizer.SpeakAsync("Appointment fix");
                    MessageBox.Show("Appointment fix");
                    

                }
                catch(SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                speechSynthesizer.SpeakAsync("Please fill form to fix appointment");
                MessageBox.Show("Please fill form to fix appointment");
                

            }
            
        }
        



        //private void Submitbutton_Click(object sender, RoutedEventArgs e)
        //{
        //    try
        //    {
        //        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");

        //        con.Open();
        //        string insertQuery = "insert into Appointment (Patient_Name,Gurdian_Name,Doctors_Name,Gender,Appointment_Date,Contact_No,Address) values ('" + txtFullName.Text + "','" + txtGurdianName.Text + "','" + comboDoctorName.Text + "','" + comboboxGender.Text + "','" + AppointmentDate.SelectedDate + "','" + txtContactNo.Text + "','" + txtAddress.Text + "')";
        //        SqlCommand com = new SqlCommand(insertQuery, con);

        //        con.Close();
        //        MessageBox.Show("Appointment Fix");
        //    }
        //    catch (SqlException ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        
    }
}
