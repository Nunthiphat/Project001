using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_001
{
    internal class userData
    {
        private string Name = "";
        private string Username = "";
        private string Password = "";

        public userData(string name)
        {
            try
            {
                string file = "C:\\source code\\oop\\Project_001\\Project_001\\user.csv";
                StreamReader sr = new StreamReader(file);
                string row = "";

                while ((row = sr.ReadLine()) != null)
                {
                    string[] data = row.Split(",");

                    this.Name = data[3];
                    this.Username = data[0];
                    this.Password = data[1];

                    if(Name.Equals(name))
                    {
                        break;
                    }
                }
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.ToString());
            }
        }

        public bool checkPass(string username, string password)
        {
            if(username.Equals(Username) &&  password.Equals(Password))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
