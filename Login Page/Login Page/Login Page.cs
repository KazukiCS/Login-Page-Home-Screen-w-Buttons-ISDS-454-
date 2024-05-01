using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Page
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Log_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home f2 = new Home();
            f2.Show();
        }
    }
}
