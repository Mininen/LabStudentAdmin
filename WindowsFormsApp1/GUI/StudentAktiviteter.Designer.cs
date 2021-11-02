namespace WindowsFormsApp1
{
    partial class StudentAktiviteter
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
            this.buttonAnmäl = new System.Windows.Forms.Button();
            this.buttonTillbaka = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewMinaAktiviteter = new System.Windows.Forms.DataGridView();
            this.DataGridViewStudentAktiviteter = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMinaAktiviteter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewStudentAktiviteter)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAnmäl
            // 
            this.buttonAnmäl.Location = new System.Drawing.Point(13, 428);
            this.buttonAnmäl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAnmäl.Name = "buttonAnmäl";
            this.buttonAnmäl.Size = new System.Drawing.Size(154, 54);
            this.buttonAnmäl.TabIndex = 15;
            this.buttonAnmäl.Text = "Anmäl till aktivitet";
            this.buttonAnmäl.UseVisualStyleBackColor = true;
            this.buttonAnmäl.Click += new System.EventHandler(this.buttonAnmäl_Click);
            // 
            // buttonTillbaka
            // 
            this.buttonTillbaka.Location = new System.Drawing.Point(992, 427);
            this.buttonTillbaka.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonTillbaka.Name = "buttonTillbaka";
            this.buttonTillbaka.Size = new System.Drawing.Size(150, 54);
            this.buttonTillbaka.TabIndex = 14;
            this.buttonTillbaka.Text = "Tillbaka";
            this.buttonTillbaka.UseVisualStyleBackColor = true;
            this.buttonTillbaka.Click += new System.EventHandler(this.buttonTillbaka_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(8, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 26);
            this.label2.TabIndex = 13;
            this.label2.Text = "Aktivitetsanmälan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(588, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 26);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mina aktivteter";
            // 
            // dataGridViewMinaAktiviteter
            // 
            this.dataGridViewMinaAktiviteter.AllowUserToAddRows = false;
            this.dataGridViewMinaAktiviteter.AllowUserToDeleteRows = false;
            this.dataGridViewMinaAktiviteter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMinaAktiviteter.Location = new System.Drawing.Point(593, 86);
            this.dataGridViewMinaAktiviteter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewMinaAktiviteter.Name = "dataGridViewMinaAktiviteter";
            this.dataGridViewMinaAktiviteter.ReadOnly = true;
            this.dataGridViewMinaAktiviteter.RowHeadersWidth = 62;
            this.dataGridViewMinaAktiviteter.Size = new System.Drawing.Size(549, 331);
            this.dataGridViewMinaAktiviteter.TabIndex = 11;
            // 
            // DataGridViewStudentAktiviteter
            // 
            this.DataGridViewStudentAktiviteter.AllowUserToAddRows = false;
            this.DataGridViewStudentAktiviteter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewStudentAktiviteter.Location = new System.Drawing.Point(13, 86);
            this.DataGridViewStudentAktiviteter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DataGridViewStudentAktiviteter.Name = "DataGridViewStudentAktiviteter";
            this.DataGridViewStudentAktiviteter.RowHeadersWidth = 62;
            this.DataGridViewStudentAktiviteter.Size = new System.Drawing.Size(552, 331);
            this.DataGridViewStudentAktiviteter.TabIndex = 10;
            // 
            // StudentAktiviteter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 500);
            this.Controls.Add(this.buttonAnmäl);
            this.Controls.Add(this.buttonTillbaka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewMinaAktiviteter);
            this.Controls.Add(this.DataGridViewStudentAktiviteter);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StudentAktiviteter";
            this.Text = "StudentAktiviteter";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMinaAktiviteter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewStudentAktiviteter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAnmäl;
        private System.Windows.Forms.Button buttonTillbaka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewMinaAktiviteter;
        private System.Windows.Forms.DataGridView DataGridViewStudentAktiviteter;
    }
}