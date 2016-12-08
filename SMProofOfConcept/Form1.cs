using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMProofOfConcept
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if(tb_Username.Text == "" || tb_Password.Text == "")
            {
                MessageBox.Show("Everything needs to be filled in");
            }


        }
    }
}
