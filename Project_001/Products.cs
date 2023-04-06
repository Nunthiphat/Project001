using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_001
{
    public class Products
    {
        public string pdName;
        public int pdPrice;
        public Products(string pdname,int pdprice)
        {
            this.pdName = pdname;
            this.pdPrice = pdprice;
        }
        public string getpdName()
        {
            return pdName;
        }
        public string getpdPrice()
        {   
            string prsPrice = pdPrice.ToString();

            return prsPrice;
        }
    }
}
