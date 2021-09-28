
namespace P2
{
    partial class frmMaestros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMaestros));
            this.maestros1 = new CapaVista.Maestros();
            this.SuspendLayout();
            // 
            // maestros1
            // 
            this.maestros1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("maestros1.BackgroundImage")));
            this.maestros1.Location = new System.Drawing.Point(0, 0);
            this.maestros1.Name = "maestros1";
            this.maestros1.Size = new System.Drawing.Size(1173, 565);
            this.maestros1.TabIndex = 0;
            // 
            // frmMaestros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 560);
            this.Controls.Add(this.maestros1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMaestros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMaestros";
            this.Load += new System.EventHandler(this.frmMaestros_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CapaVista.Maestros maestros1;
    }
}