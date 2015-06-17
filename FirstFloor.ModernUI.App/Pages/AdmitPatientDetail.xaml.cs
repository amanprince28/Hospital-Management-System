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
using System.IO;
using System.Data.SqlClient;
using System.Data;
using System.Speech.Synthesis;



namespace FirstFloor.ModernUI.App.Pages
{
    /// <summary>
    /// Interaction logic for AdmitPatientDetail.xaml
    /// </summary>
    public partial class AdmitPatientDetail : UserControl
    {

        SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
        
        public AdmitPatientDetail()
        {
            InitializeComponent();
            
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Create OpenFileDialog
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();

            // Set filter for file extension and default file extension

            dlg.Filter = "All Files (*.*)|*.*";



            // Display OpenFileDialog by calling ShowDialog method
            Nullable<bool> result = dlg.ShowDialog();

            // Get the selected file name and display in a TextBox
            if (result == true)
            {
                if (dlg.FileName.Length > 0)
                {
                    txtPReport.Text = dlg.FileName;
                    string newXPSDocumentName = String.Concat(System.IO.Path.GetDirectoryName(dlg.FileName), "\\",
                                   System.IO.Path.GetFileNameWithoutExtension(dlg.FileName), ".xps");


                }
            }



            //System.Windows.Forms.FolderBrowserDialog FBD = new System.Windows.Forms.FolderBrowserDialog();
            //if (FBD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //{
            //    ReportListBox.Items.Clear();
            //    string[] files = Directory.GetFiles(FBD.SelectedPath);
            //    string[] dirs = Directory.GetDirectories(FBD.SelectedPath);

            //    foreach (string file in files)
            //    {
            //        ReportListBox.Items.Add(System.IO.Path.GetFileName(file));

            //        ReportListBox.Items.Add(file);
            //    }
            //    foreach (string dir in dirs)
            //    {
            //        ReportListBox.Items.Add(System.IO.Path.GetFileName((dir)));
            //        ReportListBox.Items.Add((dir));
            //    }
            //}
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if ((txtPatientName.Text!="")||(txtPatientID.Text !="")||(txtBedNo.Text!="")||(txtDoctorName.Text!="")||(txtWard_RoomNo.Text!="")||(txtPReport.Text!=""))
            {
                try
                {
                    string Pname = txtPatientName.Text;
                    string pid = txtPatientID.Text;
                    string dname = txtDoctorName.Text;
                    string wrno = txtWard_RoomNo.Text;
                    string bno = txtBedNo.Text;
                    string adate = DatePickerAdmitDate.Text;
                    string ddate = DatePickerDischargeDate.Text;
                    string prep = txtPReport.Text;
                    string pdetail = combopaymentdetail.Text;

                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
                    con.Open();
                    SqlCommand com = new SqlCommand("Insert into AdmitPatient (Patient_Name,Patient_ID,Doctor_Name,Ward_Room_No,Bed_No,Admit_Date,Discharge_Date,Patient_Report,Payment_Detail) values ('" + Pname + "','" + pid + "','" + dname + "','" + wrno + "','" + bno + "','" + adate + "','" + ddate + "','" + prep + "','" + pdetail + "')", con);
                    com.CommandType = CommandType.Text;
                    com.ExecuteNonQuery();
                    con.Close();
                    speechSynthesizer.SpeakAsync("Added");

                    MessageBox.Show("Added");
                    

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                speechSynthesizer.SpeakAsync("Please fill all the field");
                MessageBox.Show("Please fill all the field");
                

            }
            
        }

    }
}
