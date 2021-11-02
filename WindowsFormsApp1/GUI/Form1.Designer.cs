namespace WindowsFormsApp1
{
    partial class Inloggning
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LLösenord = new System.Windows.Forms.TextBox();
            this.LAnvändarnamn = new System.Windows.Forms.TextBox();
            this.SLösenord = new System.Windows.Forms.TextBox();
            this.SAnvändarnamn = new System.Windows.Forms.TextBox();
            this.LoggaInLärare = new System.Windows.Forms.Button();
            this.LoggaInStudent = new System.Windows.Forms.Button();
            this.buttonAvsluta = new System.Windows.Forms.Button();
            this.FeedbackLB = new System.Windows.Forms.Label();
            this.skapaAlumnKontoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(375, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 25);
            this.label7.TabIndex = 38;
            this.label7.Text = "Personal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(169, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 25);
            this.label6.TabIndex = 37;
            this.label6.Text = "Alumn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label5.Location = new System.Drawing.Point(195, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(346, 46);
            this.label5.TabIndex = 36;
            this.label5.Text = "Högskolan i Borås";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(376, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "Lösenord:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "Lösenord:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(376, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Användarnamn:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Användarnamn:";
            // 
            // LLösenord
            // 
            this.LLösenord.Location = new System.Drawing.Point(381, 311);
            this.LLösenord.Name = "LLösenord";
            this.LLösenord.Size = new System.Drawing.Size(187, 26);
            this.LLösenord.TabIndex = 31;
            this.LLösenord.UseSystemPasswordChar = true;
            // 
            // LAnvändarnamn
            // 
            this.LAnvändarnamn.Location = new System.Drawing.Point(381, 241);
            this.LAnvändarnamn.Name = "LAnvändarnamn";
            this.LAnvändarnamn.Size = new System.Drawing.Size(187, 26);
            this.LAnvändarnamn.TabIndex = 30;
            // 
            // SLösenord
            // 
            this.SLösenord.Location = new System.Drawing.Point(174, 311);
            this.SLösenord.Name = "SLösenord";
            this.SLösenord.Size = new System.Drawing.Size(188, 26);
            this.SLösenord.TabIndex = 29;
            this.SLösenord.UseSystemPasswordChar = true;
            // 
            // SAnvändarnamn
            // 
            this.SAnvändarnamn.Location = new System.Drawing.Point(174, 241);
            this.SAnvändarnamn.Name = "SAnvändarnamn";
            this.SAnvändarnamn.Size = new System.Drawing.Size(188, 26);
            this.SAnvändarnamn.TabIndex = 28;
            // 
            // LoggaInLärare
            // 
            this.LoggaInLärare.Location = new System.Drawing.Point(381, 358);
            this.LoggaInLärare.Name = "LoggaInLärare";
            this.LoggaInLärare.Size = new System.Drawing.Size(187, 43);
            this.LoggaInLärare.TabIndex = 27;
            this.LoggaInLärare.Text = "Logga in personal";
            this.LoggaInLärare.UseVisualStyleBackColor = true;
            this.LoggaInLärare.Click += new System.EventHandler(this.LoggaInLärare_Click_1);
            // 
            // LoggaInStudent
            // 
            this.LoggaInStudent.Location = new System.Drawing.Point(174, 358);
            this.LoggaInStudent.Name = "LoggaInStudent";
            this.LoggaInStudent.Size = new System.Drawing.Size(188, 43);
            this.LoggaInStudent.TabIndex = 26;
            this.LoggaInStudent.Text = "Logga in alumn";
            this.LoggaInStudent.UseVisualStyleBackColor = true;
            this.LoggaInStudent.Click += new System.EventHandler(this.LoggaInStudent_Click);
            // 
            // buttonAvsluta
            // 
            this.buttonAvsluta.Location = new System.Drawing.Point(409, 415);
            this.buttonAvsluta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAvsluta.Name = "buttonAvsluta";
            this.buttonAvsluta.Size = new System.Drawing.Size(159, 35);
            this.buttonAvsluta.TabIndex = 39;
            this.buttonAvsluta.Text = "Avsluta";
            this.buttonAvsluta.UseVisualStyleBackColor = true;
            this.buttonAvsluta.Click += new System.EventHandler(this.buttonAvsluta_Click);
            // 
            // FeedbackLB
            // 
            this.FeedbackLB.AutoSize = true;
            this.FeedbackLB.Location = new System.Drawing.Point(203, 130);
            this.FeedbackLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FeedbackLB.Name = "FeedbackLB";
            this.FeedbackLB.Size = new System.Drawing.Size(80, 20);
            this.FeedbackLB.TabIndex = 40;
            this.FeedbackLB.Text = "Feedback";
            // 
            // skapaAlumnKontoButton
            // 
            this.skapaAlumnKontoButton.Location = new System.Drawing.Point(174, 407);
            this.skapaAlumnKontoButton.Name = "skapaAlumnKontoButton";
            this.skapaAlumnKontoButton.Size = new System.Drawing.Size(188, 43);
            this.skapaAlumnKontoButton.TabIndex = 41;
            this.skapaAlumnKontoButton.Text = "Skapa alumnkonto";
            this.skapaAlumnKontoButton.UseVisualStyleBackColor = true;
            this.skapaAlumnKontoButton.Click += new System.EventHandler(this.skapaAlumnKontoButton_Click);
            // 
            // Inloggning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 553);
            this.Controls.Add(this.skapaAlumnKontoButton);
            this.Controls.Add(this.FeedbackLB);
            this.Controls.Add(this.buttonAvsluta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LLösenord);
            this.Controls.Add(this.LAnvändarnamn);
            this.Controls.Add(this.SLösenord);
            this.Controls.Add(this.SAnvändarnamn);
            this.Controls.Add(this.LoggaInLärare);
            this.Controls.Add(this.LoggaInStudent);
            this.Name = "Inloggning";
            this.Text = "Inloggning";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LLösenord;
        private System.Windows.Forms.TextBox LAnvändarnamn;
        private System.Windows.Forms.TextBox SLösenord;
        private System.Windows.Forms.TextBox SAnvändarnamn;
        private System.Windows.Forms.Button LoggaInLärare;
        private System.Windows.Forms.Button LoggaInStudent;
        private System.Windows.Forms.Button buttonAvsluta;
        private System.Windows.Forms.Label FeedbackLB;
        private System.Windows.Forms.Button skapaAlumnKontoButton;
    }
}

