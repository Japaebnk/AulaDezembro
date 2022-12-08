using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula8dez
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelDigitado.Text = "O NOME DIGITADO FOI: \n           " + imput.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void imput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
