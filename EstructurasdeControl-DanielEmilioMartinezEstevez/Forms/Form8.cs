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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1, n2;

            if (textBox1.Text.Trim().Length == 0)
            {
                MessageBox.Show("Error ingrese un numero");
                textBox1.Focus();
                return;
            }

            if (textBox2.Text.Trim().Length == 0)
            {
                MessageBox.Show("Error ingrese un numero");
                textBox2.Focus();
                return;
            }

            n1 = Convert.ToDouble(textBox1.Text);
            n2 = Convert.ToDouble(textBox2.Text);

            if (n1 > n2)
            {
                label4.Text = Convert.ToString(n1);
                label5.Text = Convert.ToString(n2);
            }
            else
            {
                label4.Text = Convert.ToString(n2);
                label5.Text = Convert.ToString(n1);
            }
        }
    }
}
