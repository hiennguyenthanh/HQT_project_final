using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.DAO
{
    class ContractDAO
    {
        private static ContractDAO instance;

        public static ContractDAO Instance { get { if (instance == null) ContractDAO.instance = new ContractDAO(); return ContractDAO.instance; } private set => instance = value; }
        private ContractDAO()
        {
        }
    }
}
