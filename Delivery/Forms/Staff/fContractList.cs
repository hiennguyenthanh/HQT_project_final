using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delivery.Forms.Staff
{
    public partial class fContractList : Form
    {
        private string UserID;
        public fContractList(string userid)
        {
            InitializeComponent();
            this.UserID = userid;
        }
    }
}
