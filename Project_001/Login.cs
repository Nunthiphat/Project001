using System.Diagnostics;
using System.Xml.Linq;

namespace Project_001
{
    public partial class Login : Form
    {
        private userData userData;
        private string Namedata;
        private string Roledata;
        private bool PassCheck;
        public Login()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string file = "C:\\source code\\oop\\Project_001\\Project_001\\user.csv";
                StreamReader sr = new StreamReader(file);
                string row = "";

                while ((row = sr.ReadLine()) != null)
                {
                    string[] data = row.Split(",");

                    Namedata = data[3];
                    Roledata = data[2];
                    string username = usernameBox.Text;
                    string password = passwordBox.Text;

                    userData = new userData(Namedata);
                    PassCheck = userData.checkPass(username, password);

                    if (PassCheck == true)
                    {
                        break;
                    }
                    
                }

                if (PassCheck == true)
                {
                    MessageBox.Show("Login Sucess");
                    //MainProgram main = new MainProgram(Namedata);
                    if(Roledata == "admin")
                    {
                        Admin admin = new Admin();
                        admin.Show();
                    }
                    else if(Roledata == "employee")
                    {
                        employee employees = new employee();
                        employees.Show();
                    }
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Fail Login");
                }
            }
            catch (Exception a)
            {
                Console.WriteLine(a.ToString());
            }
        }
    }
}