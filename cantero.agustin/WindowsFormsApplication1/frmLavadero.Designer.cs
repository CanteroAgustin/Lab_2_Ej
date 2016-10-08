namespace WindowsFormsApplication1
{
    partial class frmLavadero
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddAuto = new System.Windows.Forms.Button();
            this.btnAddMoto = new System.Windows.Forms.Button();
            this.btnAddCamion = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.ltbLavadero = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAddAuto
            // 
            this.btnAddAuto.Location = new System.Drawing.Point(30, 38);
            this.btnAddAuto.Name = "btnAddAuto";
            this.btnAddAuto.Size = new System.Drawing.Size(75, 23);
            this.btnAddAuto.TabIndex = 0;
            this.btnAddAuto.Text = "(+)  Auto";
            this.btnAddAuto.UseVisualStyleBackColor = true;
            // 
            // btnAddMoto
            // 
            this.btnAddMoto.Location = new System.Drawing.Point(30, 85);
            this.btnAddMoto.Name = "btnAddMoto";
            this.btnAddMoto.Size = new System.Drawing.Size(75, 23);
            this.btnAddMoto.TabIndex = 1;
            this.btnAddMoto.Text = "(+)  Moto";
            this.btnAddMoto.UseVisualStyleBackColor = true;
            // 
            // btnAddCamion
            // 
            this.btnAddCamion.Location = new System.Drawing.Point(30, 132);
            this.btnAddCamion.Name = "btnAddCamion";
            this.btnAddCamion.Size = new System.Drawing.Size(75, 23);
            this.btnAddCamion.TabIndex = 2;
            this.btnAddCamion.Text = "(+)  Camion";
            this.btnAddCamion.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(30, 182);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 3;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // ltbLavadero
            // 
            this.ltbLavadero.FormattingEnabled = true;
            this.ltbLavadero.Location = new System.Drawing.Point(125, 38);
            this.ltbLavadero.Name = "ltbLavadero";
            this.ltbLavadero.Size = new System.Drawing.Size(155, 212);
            this.ltbLavadero.TabIndex = 4;
            // 
            // frmLavadero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.ltbLavadero);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnAddCamion);
            this.Controls.Add(this.btnAddMoto);
            this.Controls.Add(this.btnAddAuto);
            this.Name = "frmLavadero";
            this.Text = "frmLavadero";
            this.Load += new System.EventHandler(this.frmLavadero_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddAuto;
        private System.Windows.Forms.Button btnAddMoto;
        private System.Windows.Forms.Button btnAddCamion;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.ListBox ltbLavadero;
    }
}