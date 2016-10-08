namespace WindowsFormsApplication1
{
    partial class frmCamion
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
            this.txtTara = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtTara
            // 
            this.txtTara.Location = new System.Drawing.Point(56, 178);
            this.txtTara.Name = "txtTara";
            this.txtTara.Size = new System.Drawing.Size(174, 20);
            this.txtTara.TabIndex = 5;
            this.txtTara.Text = "Tara";
            this.txtTara.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmCamion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.txtTara);
            this.Name = "frmCamion";
            this.Text = "frmCamion";
            this.Load += new System.EventHandler(this.frmCamion_Load);
            this.Controls.SetChildIndex(this.txtTara, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTara;
    }
}