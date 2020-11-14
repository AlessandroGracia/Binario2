using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Binario2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntCalcular_Click(object sender, EventArgs e)
        {
            int dec, bin;
            string sal = "";
            dec = Convert.ToInt16(textEntrada.Text);


            while (dec > 0)
            {

                bin = dec % 2;
                dec = dec / 2;
                Convert.ToString(bin);
                sal = bin + sal;
                textSalida.Text = Convert.ToString(sal);

            }

            textEntrada.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bntSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
