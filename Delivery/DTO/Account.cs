using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery
{
    
    public class Account
    {
        private string userName;
        private string userPass;
        private string statusAcc;

        public Account(string userName, string userPass, string statusAcc)
        {
            this.userName = userName;
            this.userPass = userPass;
            this.statusAcc = statusAcc;
        }

        public string UserName { get => userName; set => userName = value; }
        public string UserPass { get => userPass; set => userPass = value; }
        public string StatusAcc { get => statusAcc; set => statusAcc = value; }
    }
}
