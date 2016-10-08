namespace Clase08
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.mtxtLegajo = new System.Windows.Forms.MaskedTextBox();
            this.cmbPuesto = new System.Windows.Forms.ComboBox();
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleadoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.empleadoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.mtxtSalario = new System.Windows.Forms.MaskedTextBox();
            this.btnEmpresa = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 24);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(12, 49);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido";
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Location = new System.Drawing.Point(12, 73);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(39, 13);
            this.lblLegajo.TabIndex = 2;
            this.lblLegajo.Text = "Legajo";
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Location = new System.Drawing.Point(12, 97);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(40, 13);
            this.lblPuesto.TabIndex = 3;
            this.lblPuesto.Text = "Puesto";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(12, 120);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(58, 13);
            this.lblSalario.TabIndex = 4;
            this.lblSalario.Text = "Ganancias";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(108, 17);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(171, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(108, 42);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(171, 20);
            this.txtApellido.TabIndex = 6;
            // 
            // mtxtLegajo
            // 
            this.mtxtLegajo.Location = new System.Drawing.Point(108, 66);
            this.mtxtLegajo.Mask = "000-0000-00";
            this.mtxtLegajo.Name = "mtxtLegajo";
            this.mtxtLegajo.Size = new System.Drawing.Size(171, 20);
            this.mtxtLegajo.TabIndex = 7;
            // 
            // cmbPuesto
            // 
            this.cmbPuesto.DataSource = this.empleadoBindingSource2;
            this.cmbPuesto.FormattingEnabled = true;
            this.cmbPuesto.Location = new System.Drawing.Point(108, 89);
            this.cmbPuesto.Name = "cmbPuesto";
            this.cmbPuesto.Size = new System.Drawing.Size(171, 21);
            this.cmbPuesto.TabIndex = 8;
            // 
            // empleadoBindingSource
            // 
            this.empleadoBindingSource.DataSource = typeof(MiLibreria.Empleado);
            // 
            // empleadoBindingSource1
            // 
            this.empleadoBindingSource1.DataSource = typeof(MiLibreria.Empleado);
            // 
            // empleadoBindingSource2
            // 
            this.empleadoBindingSource2.DataSource = typeof(MiLibreria.Empleado);
            // 
            // mtxtSalario
            // 
            this.mtxtSalario.Location = new System.Drawing.Point(108, 113);
            this.mtxtSalario.Mask = "$0000.00";
            this.mtxtSalario.Name = "mtxtSalario";
            this.mtxtSalario.Size = new System.Drawing.Size(62, 20);
            this.mtxtSalario.TabIndex = 9;
            // 
            // btnEmpresa
            // 
            this.btnEmpresa.Location = new System.Drawing.Point(15, 152);
            this.btnEmpresa.Name = "btnEmpresa";
            this.btnEmpresa.Size = new System.Drawing.Size(62, 31);
            this.btnEmpresa.TabIndex = 10;
            this.btnEmpresa.Text = "Empresa";
            this.btnEmpresa.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(203, 152);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 31);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(122, 152);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 31);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 317);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnEmpresa);
            this.Controls.Add(this.mtxtSalario);
            this.Controls.Add(this.cmbPuesto);
            this.Controls.Add(this.mtxtLegajo);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblPuesto);
            this.Controls.Add(this.lblLegajo);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.MaskedTextBox mtxtLegajo;
        private System.Windows.Forms.ComboBox cmbPuesto;
        private System.Windows.Forms.BindingSource empleadoBindingSource2;
        private System.Windows.Forms.BindingSource empleadoBindingSource;
        private System.Windows.Forms.BindingSource empleadoBindingSource1;
        private System.Windows.Forms.MaskedTextBox mtxtSalario;
        private System.Windows.Forms.Button btnEmpresa;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

