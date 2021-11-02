namespace WindowsFormsApp1
{
    partial class LärarMeny
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
            this.buttonUtskick = new System.Windows.Forms.Button();
            this.buttonAktiviteter = new System.Windows.Forms.Button();
            this.buttonSkapaAktiviteter = new System.Windows.Forms.Button();
            this.buttonLoggaUt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonUtskick
            // 
            this.buttonUtskick.Location = new System.Drawing.Point(201, 175);
            this.buttonUtskick.Name = "buttonUtskick";
            this.buttonUtskick.Size = new System.Drawing.Size(131, 45);
            this.buttonUtskick.TabIndex = 5;
            this.buttonUtskick.Text = "Skapa utskickslista";
            this.buttonUtskick.UseVisualStyleBackColor = true;
            this.buttonUtskick.Click += new System.EventHandler(this.buttonUtskick_Click);
            // 
            // buttonAktiviteter
            // 
            this.buttonAktiviteter.Location = new System.Drawing.Point(201, 109);
            this.buttonAktiviteter.Name = "buttonAktiviteter";
            this.buttonAktiviteter.Size = new System.Drawing.Size(131, 44);
            this.buttonAktiviteter.TabIndex = 4;
            this.buttonAktiviteter.Text = "Hantera aktiviteter";
            this.buttonAktiviteter.UseVisualStyleBackColor = true;
            this.buttonAktiviteter.Click += new System.EventHandler(this.buttonAktiviteter_Click);
            // 
            // buttonSkapaAktiviteter
            // 
            this.buttonSkapaAktiviteter.Location = new System.Drawing.Point(201, 40);
            this.buttonSkapaAktiviteter.Name = "buttonSkapaAktiviteter";
            this.buttonSkapaAktiviteter.Size = new System.Drawing.Size(131, 44);
            this.buttonSkapaAktiviteter.TabIndex = 6;
            this.buttonSkapaAktiviteter.Text = "Skapa aktiviteter";
            this.buttonSkapaAktiviteter.UseVisualStyleBackColor = true;
            this.buttonSkapaAktiviteter.Click += new System.EventHandler(this.buttonSkapaAktiviteter_Click);
            // 
            // buttonLoggaUt
            // 
            this.buttonLoggaUt.Location = new System.Drawing.Point(224, 246);
            this.buttonLoggaUt.Name = "buttonLoggaUt";
            this.buttonLoggaUt.Size = new System.Drawing.Size(75, 23);
            this.buttonLoggaUt.TabIndex = 7;
            this.buttonLoggaUt.Text = "Logga ut";
            this.buttonLoggaUt.UseVisualStyleBackColor = true;
            this.buttonLoggaUt.Click += new System.EventHandler(this.buttonLoggaUt_Click);
            // 
            // LärarMeny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.buttonLoggaUt);
            this.Controls.Add(this.buttonSkapaAktiviteter);
            this.Controls.Add(this.buttonUtskick);
            this.Controls.Add(this.buttonAktiviteter);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LärarMeny";
            this.Text = "LärarMeny";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonUtskick;
        private System.Windows.Forms.Button buttonAktiviteter;
        private System.Windows.Forms.Button buttonSkapaAktiviteter;
        private System.Windows.Forms.Button buttonLoggaUt;
    }
}