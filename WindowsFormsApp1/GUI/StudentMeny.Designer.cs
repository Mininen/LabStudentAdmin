namespace WindowsFormsApp1
{
    partial class StudentMeny
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
            this.Aktivitetsanmälan = new System.Windows.Forms.Button();
            this.redigeraProfil = new System.Windows.Forms.Button();
            this.buttonLoggaUt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Aktivitetsanmälan
            // 
            this.Aktivitetsanmälan.Location = new System.Drawing.Point(284, 184);
            this.Aktivitetsanmälan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Aktivitetsanmälan.Name = "Aktivitetsanmälan";
            this.Aktivitetsanmälan.Size = new System.Drawing.Size(234, 82);
            this.Aktivitetsanmälan.TabIndex = 5;
            this.Aktivitetsanmälan.Text = "Anmälan till aktiviteter";
            this.Aktivitetsanmälan.UseVisualStyleBackColor = true;
            this.Aktivitetsanmälan.Click += new System.EventHandler(this.Aktivitetsanmälan_Click);
            // 
            // redigeraProfil
            // 
            this.redigeraProfil.Location = new System.Drawing.Point(284, 67);
            this.redigeraProfil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.redigeraProfil.Name = "redigeraProfil";
            this.redigeraProfil.Size = new System.Drawing.Size(234, 82);
            this.redigeraProfil.TabIndex = 4;
            this.redigeraProfil.Text = "Redigera profil";
            this.redigeraProfil.UseVisualStyleBackColor = true;
            this.redigeraProfil.Click += new System.EventHandler(this.redigeraProfil_Click);
            // 
            // buttonLoggaUt
            // 
            this.buttonLoggaUt.Location = new System.Drawing.Point(284, 294);
            this.buttonLoggaUt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLoggaUt.Name = "buttonLoggaUt";
            this.buttonLoggaUt.Size = new System.Drawing.Size(234, 35);
            this.buttonLoggaUt.TabIndex = 6;
            this.buttonLoggaUt.Text = "Logga ut";
            this.buttonLoggaUt.UseVisualStyleBackColor = true;
            this.buttonLoggaUt.Click += new System.EventHandler(this.buttonLoggaUt_Click);
            // 
            // StudentMeny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.buttonLoggaUt);
            this.Controls.Add(this.Aktivitetsanmälan);
            this.Controls.Add(this.redigeraProfil);
            this.Name = "StudentMeny";
            this.Text = "StudentMeny";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Aktivitetsanmälan;
        private System.Windows.Forms.Button redigeraProfil;
        private System.Windows.Forms.Button buttonLoggaUt;
    }
}