using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        int startponint = 0;
      
        private void timer1_Tick(object sender, EventArgs e)
        {
            startponint += 2;
            bunifuProgressBar1.Value = startponint;
            if (bunifuProgressBar1.Value == 100)
            {
                bunifuProgressBar1.Value = 0;
                timer1.Stop();
                LoginForm frm1 = new LoginForm();
                this.Hide();
                frm1.Show();
            }
        }
    }
}
