namespace capaPresentacion
{
    partial class Menu
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
            this.Gestionbtn = new System.Windows.Forms.Button();
            this.Reportesbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Gestionbtn
            // 
            this.Gestionbtn.Location = new System.Drawing.Point(34, 36);
            this.Gestionbtn.Name = "Gestionbtn";
            this.Gestionbtn.Size = new System.Drawing.Size(175, 141);
            this.Gestionbtn.TabIndex = 0;
            this.Gestionbtn.Text = "Gestion";
            this.Gestionbtn.UseVisualStyleBackColor = true;
            this.Gestionbtn.Click += new System.EventHandler(this.Gestionbtn_Click);
            // 
            // Reportesbtn
            // 
            this.Reportesbtn.Location = new System.Drawing.Point(250, 36);
            this.Reportesbtn.Name = "Reportesbtn";
            this.Reportesbtn.Size = new System.Drawing.Size(184, 141);
            this.Reportesbtn.TabIndex = 1;
            this.Reportesbtn.Text = "Reportes";
            this.Reportesbtn.UseVisualStyleBackColor = true;
            this.Reportesbtn.Click += new System.EventHandler(this.Reportesbtn_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 229);
            this.Controls.Add(this.Reportesbtn);
            this.Controls.Add(this.Gestionbtn);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Gestionbtn;
        private System.Windows.Forms.Button Reportesbtn;
    }
}