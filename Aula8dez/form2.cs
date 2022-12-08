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
    public partial class form2 : Form
    {
        public form2()
        {
            InitializeComponent();
        }

        private void form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void limpar_Click(object sender, EventArgs e)
        {
            
           
        }

        private void keyDown(object sender, KeyEventArgs e)
        {
            imput2.AppendText("\r\n" + "Pressionei a tecla: " + e.KeyCode);
            imput2.AppendText("\r\n" + "Codigo da tecla: " + ((int)e.KeyCode));


        }

        private void imput1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
