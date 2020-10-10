using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructurasdeControl_DanielEmilioMartinezEstevez.Forms
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double total, n1;

            if (textBox1.Text.Trim().Length == 0)
            {
                MessageBox.Show("Error ingrese un digito");
                textBox1.Focus();
                return;
            }

            n1 = Convert.ToDouble(textBox1.Text);
            
            if (n1 >= 10)
            {
                total = n1 * 2;
                label4.Text = Convert.ToString(total);
            }
            else
            {
                total = n1 * 3;
                label4.Text = Convert.ToString(total);
            }


        }
    }
}
