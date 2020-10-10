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
    public partial class Form15 : Form
    {
        double cont;
        public Form15()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int x = 0; x <= 98; x++)
            {
                cont = (x + 1) + cont;
            }

            textBox1.Text = Convert.ToString(cont);
        }
    }
}
