using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        Menu mn = new Menu();

        private void button1_Click(object sender, EventArgs e)
        {
            if (Userbox.Text == "Edw" && Passbox.Text == "12345")
            {
             
                mn.ShowDialog();

            }
            else
            {
                mn.ShowDialog();
            }

        }
    }
}
