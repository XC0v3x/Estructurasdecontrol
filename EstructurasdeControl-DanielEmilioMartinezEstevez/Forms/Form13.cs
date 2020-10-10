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
    public partial class Form13 : Form
    {
        double aprovado = 0, reporbado = 0;
        public Form13()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double nota;

            if (textBox1.Text.Trim().Length == 0)
            {
                MessageBox.Show("Error el campo no puede estar vacio");
                textBox1.Focus();
                return;
            }

            if (textBox2.Text.Trim().Length == 0)
            {
                MessageBox.Show("Error el campo no puede estar vacio");
                textBox2.Focus();
                return;
            }

            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);

            nota = Convert.ToDouble(textBox2.Text);

            if (nota >= 65)
            {
                aprovado++;
            }
            else
            {
                reporbado++;
            }

            label10.Text = Convert.ToString(aprovado);
            label9.Text = Convert.ToString(reporbado);
        }
    }
}
