using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlitzLogin.Views
{
    public partial class FundoDeTela : Form
    {
        public FundoDeTela()
        {
            InitializeComponent();
        }

        private void FundoDeTela_Activated(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
            Application.Exit();
        }
    }
}
