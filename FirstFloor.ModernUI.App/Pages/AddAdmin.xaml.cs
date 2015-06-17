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
using System.Data;
using System.Text.RegularExpressions;
using System.Speech.Synthesis;

namespace ModernUINavigationApp3.Pages
{
    /// <summary>
    /// Interaction logic for AddAdmin.xaml
    /// </summary>
    public partial class AddAdmin : UserControl
    {
        SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
        public AddAdmin()
        {
            InitializeComponent();
        }
        
        private void Submit_button(object sender, RoutedEventArgs e)
        {
            
            if ((txtFullName.Text != "") && (txtRegistrationId.Text != "") && (txtUserName.Text != "") && (txtPassword.Password != "") && (txtContactNo.Text != "") && (txtEmailId.Text !=""))
            {
                try
                {
                    if(txtEmailId.Text.Length == 0)
                    {
                        speechSynthesizer.SpeakAsync("Enter the Email Id");
                        MessageBox.Show("Enter the Email Id");
                    }
                    else if (!Regex.IsMatch(txtEmailId.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
                    {
                        speechSynthesizer.SpeakAsync("Enter a valid email");
                        MessageBox.Show("Enter a valid email.");
                        
                    }
                    else if(txtContactNo.Text.Length != 10)  
                    {
                        speechSynthesizer.SpeakAsync("Enter correct contact no.");
                        MessageBox.Show("Enter correct contact no.");
                    }
                    else
                    {
                        string fname = txtFullName.Text;
                        string reg = txtRegistrationId.Text;
                        string uname = txtUserName.Text;
                        string password = txtPassword.Password;
                        string cno = txtContactNo.Text;
                        string add = txtAddress.Text;
                        string gen = comboboxGender.Text;
                        string email = txtEmailId.Text;
                        
                        if (txtPassword.Password.Length == 0)
                        {
                            speechSynthesizer.SpeakAsync("Enter password");
                            MessageBox.Show("Enter password.");
                            
                        }
                        else
                        {
                            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
                            con.Open();
                            SqlCommand cmd = new SqlCommand("Insert into Admin (Full_Name,Registration_Id,User_Name,Password,Contact_No,Address,Gender,Email_Id) values('" + fname + "','" + reg + "','" + uname + "','" + password + "','" + cno + "','"+add+"','"+gen+"','"+email+"')", con);
                            cmd.CommandType = CommandType.Text;
                            cmd.ExecuteNonQuery();
                            con.Close();

                            speechSynthesizer.SpeakAsync("Admin added");
                            MessageBox.Show("Admin added");

                            
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString(), "Error");
                }
            }
            else
            {
                speechSynthesizer.SpeakAsync("Please fill the all required field correctly");
                MessageBox.Show("Please fill the all required field correctly");
                
            }
     
            }
    }
}
