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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1;

            if (textBox1.Text.Trim().Length == 0)
            {
                MessageBox.Show("Error ingrese un numero");
                textBox1.Focus();
                return;
            }

            n1 = Convert.ToDouble(textBox1.Text);
            if (n1 >= 0)
            {
                label4.Text = "Positivo";
            }else
            {
                label4.Text = "Negativo";
            }
        }
    }
}
