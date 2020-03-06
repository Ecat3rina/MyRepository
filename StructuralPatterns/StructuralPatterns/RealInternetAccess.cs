using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralPatterns
{
    public interface IInternetAccess
    {
        void grantInternetAccess();
    }
    class RealInternetAccess : IInternetAccess
    {
        private string User_Name;

        public RealInternetAccess(string user_name)
        {
            this.User_Name = user_name;
        }

        public void grantInternetAccess()
        {
            Console.WriteLine($"Internet access granted for user {this.User_Name}");
        }
    }
}
