namespace WindowsFormsApplication1
{
    partial class frmVehiculo
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
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.txtCantRuedas = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(56, 88);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(174, 20);
            this.txtPatente.TabIndex = 1;
            this.txtPatente.Text = "Patente";
            this.txtPatente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCantRuedas
            // 
            this.txtCantRuedas.Location = new System.Drawing.Point(56, 134);
            this.txtCantRuedas.Name = "txtCantRuedas";
            this.txtCantRuedas.Size = new System.Drawing.Size(174, 20);
            this.txtCantRuedas.TabIndex = 2;
            this.txtCantRuedas.Text = "Cantidad de ruedas";
            this.txtCantRuedas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(25, 217);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(88, 44);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(181, 217);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 44);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbMarca
            // 
            this.cmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(56, 40);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbMarca.Size = new System.Drawing.Size(174, 21);
            this.cmbMarca.TabIndex = 5;
            // 
            // frmVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 273);
            this.Controls.Add(this.cmbMarca);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtCantRuedas);
            this.Controls.Add(this.txtPatente);
            this.Name = "frmVehiculo";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmVehiculo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.TextBox txtCantRuedas;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cmbMarca;
    }
}

