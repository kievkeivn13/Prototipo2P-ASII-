
namespace P2
{
    partial class frmAlumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlumno));
            this.alumnos1 = new CapaVista.Alumnos();
            this.SuspendLayout();
            // 
            // alumnos1
            // 
            this.alumnos1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("alumnos1.BackgroundImage")));
            this.alumnos1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.alumnos1.Location = new System.Drawing.Point(2, -1);
            this.alumnos1.Name = "alumnos1";
            this.alumnos1.Size = new System.Drawing.Size(1187, 558);
            this.alumnos1.TabIndex = 0;
            // 
            // frmAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 549);
            this.Controls.Add(this.alumnos1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAlumno";
            this.ResumeLayout(false);

        }

        #endregion

        private CapaVista.Alumnos alumnos1;
    }
}