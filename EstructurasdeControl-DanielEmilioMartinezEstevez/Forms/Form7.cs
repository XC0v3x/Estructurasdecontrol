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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double total, unidad, precio;

            if (textBox1.Text.Trim().Length == 0)
            {
                MessageBox.Show("Error Ingrese una cantidad");
                textBox1.Focus();
                return;
            }

            unidad = Convert.ToDouble(textBox1.Text);

            if (unidad >= 10)
            {
                precio = 80;
            }
            else
            {
                precio = 100;
            }

            total = unidad * precio;
            label5.Text = Convert.ToString(total);
        }
    }
}
