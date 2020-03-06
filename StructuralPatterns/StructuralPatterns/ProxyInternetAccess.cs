using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace StructuralPatterns
{
    public class ProxyInternetAccess:IInternetAccess
    {
        private string User_Name;
        private RealInternetAccess realaccess;

        public ProxyInternetAccess(string user_name)
        {
            this.User_Name = user_name;
        }

        public void grantInternetAccess()
        {
            if (InternetBillPay())
            {
                realaccess=new RealInternetAccess(this.User_Name);
                realaccess.grantInternetAccess();
            }
            else
            Console.WriteLine($"No Internet Access for  {this.User_Name}");
        }
        public bool InternetBillPay()
        {
            return false;
        }
    }
}
