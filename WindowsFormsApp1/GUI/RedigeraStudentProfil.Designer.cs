namespace WindowsFormsApp1
{
    partial class RedigeraStudentProfil
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
            this.buttonSpara = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AnvändarnamnTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LösenordTB = new System.Windows.Forms.TextBox();
            this.EmailTB = new System.Windows.Forms.TextBox();
            this.NamnTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonTillbaka = new System.Windows.Forms.Button();
            this.taBortKontoButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSpara
            // 
            this.buttonSpara.Location = new System.Drawing.Point(186, 385);
            this.buttonSpara.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSpara.Name = "buttonSpara";
            this.buttonSpara.Size = new System.Drawing.Size(112, 35);
            this.buttonSpara.TabIndex = 9;
            this.buttonSpara.Text = "Spara";
            this.buttonSpara.UseVisualStyleBackColor = true;
            this.buttonSpara.Click += new System.EventHandler(this.buttonSpara_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AnvändarnamnTB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.LösenordTB);
            this.groupBox1.Controls.Add(this.EmailTB);
            this.groupBox1.Controls.Add(this.NamnTB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(186, 30);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(429, 345);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Redigera Profil";
            // 
            // AnvändarnamnTB
            // 
            this.AnvändarnamnTB.Location = new System.Drawing.Point(170, 131);
            this.AnvändarnamnTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AnvändarnamnTB.Name = "AnvändarnamnTB";
            this.AnvändarnamnTB.Size = new System.Drawing.Size(229, 26);
            this.AnvändarnamnTB.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 134);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Användarnamn";
            // 
            // LösenordTB
            // 
            this.LösenordTB.Location = new System.Drawing.Point(170, 167);
            this.LösenordTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LösenordTB.Name = "LösenordTB";
            this.LösenordTB.Size = new System.Drawing.Size(229, 26);
            this.LösenordTB.TabIndex = 5;
            // 
            // EmailTB
            // 
            this.EmailTB.Location = new System.Drawing.Point(170, 95);
            this.EmailTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EmailTB.Name = "EmailTB";
            this.EmailTB.Size = new System.Drawing.Size(229, 26);
            this.EmailTB.TabIndex = 4;
            // 
            // NamnTB
            // 
            this.NamnTB.Location = new System.Drawing.Point(170, 59);
            this.NamnTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NamnTB.Name = "NamnTB";
            this.NamnTB.Size = new System.Drawing.Size(229, 26);
            this.NamnTB.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 170);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lösenord";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Namn";
            // 
            // buttonTillbaka
            // 
            this.buttonTillbaka.Location = new System.Drawing.Point(503, 385);
            this.buttonTillbaka.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonTillbaka.Name = "buttonTillbaka";
            this.buttonTillbaka.Size = new System.Drawing.Size(112, 35);
            this.buttonTillbaka.TabIndex = 7;
            this.buttonTillbaka.Text = "Tillbaka";
            this.buttonTillbaka.UseVisualStyleBackColor = true;
            this.buttonTillbaka.Click += new System.EventHandler(this.buttonTillbaka_Click);
            // 
            // taBortKontoButton
            // 
            this.taBortKontoButton.Location = new System.Drawing.Point(325, 385);
            this.taBortKontoButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.taBortKontoButton.Name = "taBortKontoButton";
            this.taBortKontoButton.Size = new System.Drawing.Size(153, 35);
            this.taBortKontoButton.TabIndex = 10;
            this.taBortKontoButton.Text = "Ta bort konto";
            this.taBortKontoButton.UseVisualStyleBackColor = true;
            this.taBortKontoButton.Click += new System.EventHandler(this.taBortKontoButton_Click);
            // 
            // RedigeraStudentProfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.taBortKontoButton);
            this.Controls.Add(this.buttonSpara);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonTillbaka);
            this.Name = "RedigeraStudentProfil";
            this.Text = "RedigeraStudentProfil";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSpara;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox LösenordTB;
        private System.Windows.Forms.TextBox EmailTB;
        private System.Windows.Forms.TextBox NamnTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonTillbaka;
        private System.Windows.Forms.TextBox AnvändarnamnTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button taBortKontoButton;
    }
}