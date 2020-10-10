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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double total, cant, desc, pre;

            if (textBox1.Text.Trim().Length == 0)
            {
                MessageBox.Show("Error Ingrese un valor");
                textBox1.Focus();
                return;
            }

            if (textBox2.Text.Trim().Length == 0)
            {
                MessageBox.Show("Error Ingrese un Valor");
                textBox2.Focus();
                return;
            }

            cant = Convert.ToDouble(textBox1.Text);
            pre = Convert.ToDouble(textBox2.Text);
            
            if (cant >= 3)
            {
                desc = pre * 0.20;
                label5.Text = Convert.ToString(desc);
            }
            else
            {
                desc = 0;
                label5.Text = Convert.ToString(desc);
            }

            total = (cant * pre) - desc;
            label7.Text = Convert.ToString(total);


        }
    }
}
