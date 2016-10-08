using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase07
{
    public partial class Bienvenido : Form
    {
        int cont = 0;
        public Bienvenido()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Text = "Bienvenido" + DateTime.Now.ToString();
            this.label1.Text = "Hola Mundo";
            this.label1.ForeColor = Color.Purple;
            switch(cont){
                case 1:
                    this.label1.ForeColor = Color.Red;
                break;
                case 2:
                    this.label1.ForeColor = Color.Green;
                break;
                case 3:
                this.label1.ForeColor = Color.Yellow;
                break;
                case 4:
                this.label1.ForeColor = Color.Blue;
                break;
                default:
                this.label1.ForeColor = Color.Purple;
                cont = 0;
                break;
            }
            cont++;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
