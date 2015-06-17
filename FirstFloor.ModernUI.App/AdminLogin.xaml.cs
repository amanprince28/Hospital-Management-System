using FirstFloor.ModernUI.Windows.Controls;
using System;
using System.Collections.Generic;
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
using System.Speech;
using System.Speech.Synthesis;


namespace FirstFloor.ModernUI.App
{
    /// <summary>
    /// Interaction logic for AdminLogin.xaml
    /// </summary>
    public partial class AdminLogin : ModernWindow
    {
        //protected SpeechSynthesizer talker;
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DoctorsLogin dl = new DoctorsLogin();
            dl.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            EmployeeLogin el = new EmployeeLogin();
            el.Show();
            this.Close();
        }

        private void Login_button_Click(object sender, RoutedEventArgs e)
        {
            if ((txtUserName.Text != "") && (txtPassword.Password != ""))
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
                con.Open();
                string q = "select * from Admin where User_Name=@User_Name and Password=@Password";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.Parameters.AddWithValue("@User_Name", this.txtUserName.Text);
                cmd.Parameters.AddWithValue("@Password", this.txtPassword.Password);

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr.HasRows == true)
                    {
                        MainWindow mw = new MainWindow();
                        mw.Show();
                        this.Close();
                        SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
                        speechSynthesizer.SpeakAsync("Welcome sir");
                    }
                }
                if (dr.HasRows == false)
                {
                    SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
                    speechSynthesizer.SpeakAsync("Access Denied, password username mismatched");
                    //talker.Speak("Access Denied, password username mismatched");
                    MessageBox.Show("Access Denied, password username mismatched");
                }
                con.Close();
            }
            else
            {
                SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
                speechSynthesizer.SpeakAsync("Enter username and password");
                //talker.Speak("Enter username and password");
                MessageBox.Show("Enter username and password");
            }
        }

        private void ModernWindow_ContentRendered(object sender, EventArgs e)
        {
            SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
            speechSynthesizer.SpeakAsync("Please Enter username and password");
        }
    }
}
