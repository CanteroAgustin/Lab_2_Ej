using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.cmbPuesto.DataSource = Enum.GetValues(typeof(EPuestoJerarquico));
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNombre.Text = "";
            this.txtApellido.Text = "";
            this.mtxtLegajo.Text = "";
            this.mtxtSalario.Text = "";
            this.cmbPuesto.Text = "";
        }
    }
}
