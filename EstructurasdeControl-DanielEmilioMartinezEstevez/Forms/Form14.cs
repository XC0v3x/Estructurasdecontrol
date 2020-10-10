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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double numero, multi, resultado;

            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();

            if (textBox1.Text.Trim().Length == 0)
            {
                MessageBox.Show("Error el campo esta en blanco");
                textBox1.Focus();
                return;
            }

            numero = Convert.ToDouble(textBox1.Text);

            if ((numero > 10) || (numero <= 0))
            {
                MessageBox.Show("El numero ingresado no es valido");
                textBox1.Focus();
                return;
            }

            for (int x = 0; x < 10; x++)
            {
                listBox1.Items.Add(numero);
                listBox2.Items.Add(x + 1);
                multi = x + 1;
                resultado = numero * multi;
                listBox3.Items.Add(Convert.ToString(resultado));
            }

            
        }
    }
}
