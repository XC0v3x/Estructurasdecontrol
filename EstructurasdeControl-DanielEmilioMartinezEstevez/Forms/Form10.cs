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
    public partial class Form10 : Form
    {
        public Form10()
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
                MessageBox.Show("Error el campo no puede estar en blanco");
                textBox1.Focus();
                return;
            }

            if (textBox2.Text.Trim().Length == 0)
            {
                MessageBox.Show("Error el campo no puede estar en blanco");
                textBox2.Focus();
                return;
            }

            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);

            nota = Convert.ToDouble(textBox2.Text);

            if (nota >= 65)
            {
                listBox3.Items.Add("Abrobado");
            }
            else
            {
                listBox3.Items.Add("Reprobado");
            }

            textBox1.Text = " ";
            textBox2.Text = " ";
        }
    }
}
