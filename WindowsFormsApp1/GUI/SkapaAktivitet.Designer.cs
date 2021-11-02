namespace WindowsFormsApp1
{
    partial class SkapaAktivitet
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
            this.buttonTillbaka = new System.Windows.Forms.Button();
            this.groupBoxSkapaAktivitet = new System.Windows.Forms.GroupBox();
            this.NamnTB = new System.Windows.Forms.TextBox();
            this.BeskrivningTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSkapa = new System.Windows.Forms.Button();
            this.groupBoxSkapaAktivitet.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonTillbaka
            // 
            this.buttonTillbaka.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonTillbaka.Location = new System.Drawing.Point(304, 383);
            this.buttonTillbaka.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonTillbaka.Name = "buttonTillbaka";
            this.buttonTillbaka.Size = new System.Drawing.Size(112, 35);
            this.buttonTillbaka.TabIndex = 35;
            this.buttonTillbaka.Text = "Tillbaka";
            this.buttonTillbaka.UseVisualStyleBackColor = true;
            this.buttonTillbaka.Click += new System.EventHandler(this.buttonTillbaka_Click);
            // 
            // groupBoxSkapaAktivitet
            // 
            this.groupBoxSkapaAktivitet.Controls.Add(this.NamnTB);
            this.groupBoxSkapaAktivitet.Controls.Add(this.BeskrivningTB);
            this.groupBoxSkapaAktivitet.Controls.Add(this.label3);
            this.groupBoxSkapaAktivitet.Controls.Add(this.label2);
            this.groupBoxSkapaAktivitet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBoxSkapaAktivitet.Location = new System.Drawing.Point(64, 51);
            this.groupBoxSkapaAktivitet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxSkapaAktivitet.Name = "groupBoxSkapaAktivitet";
            this.groupBoxSkapaAktivitet.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxSkapaAktivitet.Size = new System.Drawing.Size(352, 289);
            this.groupBoxSkapaAktivitet.TabIndex = 36;
            this.groupBoxSkapaAktivitet.TabStop = false;
            this.groupBoxSkapaAktivitet.Text = "Skapa aktivitet";
            // 
            // NamnTB
            // 
            this.NamnTB.Location = new System.Drawing.Point(111, 78);
            this.NamnTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NamnTB.Name = "NamnTB";
            this.NamnTB.Size = new System.Drawing.Size(230, 28);
            this.NamnTB.TabIndex = 1;
            // 
            // BeskrivningTB
            // 
            this.BeskrivningTB.Location = new System.Drawing.Point(111, 118);
            this.BeskrivningTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BeskrivningTB.Name = "BeskrivningTB";
            this.BeskrivningTB.Size = new System.Drawing.Size(230, 28);
            this.BeskrivningTB.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(103, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Beskrivning";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(57, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Namn";
            // 
            // buttonSkapa
            // 
            this.buttonSkapa.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSkapa.Location = new System.Drawing.Point(64, 383);
            this.buttonSkapa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSkapa.Name = "buttonSkapa";
            this.buttonSkapa.Size = new System.Drawing.Size(112, 35);
            this.buttonSkapa.TabIndex = 34;
            this.buttonSkapa.Text = "Skapa";
            this.buttonSkapa.UseVisualStyleBackColor = true;
            this.buttonSkapa.Click += new System.EventHandler(this.buttonSkapa_Click);
            // 
            // SkapaAktivitet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 520);
            this.Controls.Add(this.buttonTillbaka);
            this.Controls.Add(this.groupBoxSkapaAktivitet);
            this.Controls.Add(this.buttonSkapa);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SkapaAktivitet";
            this.Text = "SkapaAktivitet";
            this.groupBoxSkapaAktivitet.ResumeLayout(false);
            this.groupBoxSkapaAktivitet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonTillbaka;
        private System.Windows.Forms.GroupBox groupBoxSkapaAktivitet;
        private System.Windows.Forms.TextBox NamnTB;
        private System.Windows.Forms.TextBox BeskrivningTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSkapa;
    }
}