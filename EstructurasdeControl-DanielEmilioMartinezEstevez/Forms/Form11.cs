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
    public partial class Form11 : Form
    {
       double  total = 0;
        public Form11()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double precio = 0, cantidad = 0, subtotal = 0; 

            if (textBox1.Text.Trim().Length == 0)
            {
                MessageBox.Show("Error cambo no puede estar vacio");
                textBox1.Focus();
                return;
            }

            if (textBox2.Text.Trim().Length == 0)
            {
                MessageBox.Show("Error cambo no puede estar vacio");
                textBox2.Focus();
                return;
            }

            if (textBox3.Text.Trim().Length == 0)
            {
                MessageBox.Show("Error cambo no puede estar vacio");
                textBox3.Focus();
                return;
            }

            if (textBox4.Text.Trim().Length == 0)
            {
                MessageBox.Show("Error cambo no puede estar vacio");
                textBox4.Focus();
                return;
            }

            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(textBox3.Text);
            

            precio = Convert.ToDouble(textBox2.Text);
            cantidad = Convert.ToDouble(textBox3.Text);

            subtotal = precio * cantidad;
            listBox4.Items.Add(Convert.ToString(subtotal));
            total = subtotal + total;
            textBox5.Text = Convert.ToString(total);

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void Form11_Load(object sender, EventArgs e)
        {
       
        }
    }
}
