namespace WindowsFormsApp1
{
    partial class RedigeraAktivitetPersonal
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
            this.buttonSpara1 = new System.Windows.Forms.Button();
            this.buttonRedigeraAktivitet = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewRedigeraAktivitet = new System.Windows.Forms.DataGridView();
            this.groupBoxRedigeraAktivitet = new System.Windows.Forms.GroupBox();
            this.aktivitetsIdTB = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.aktivitetsnamnTB = new System.Windows.Forms.TextBox();
            this.beskrivningTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonTillbaka = new System.Windows.Forms.Button();
            this.buttonTaBortAktivitet = new System.Windows.Forms.Button();
            this.visaDeltagareButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.deltagareDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRedigeraAktivitet)).BeginInit();
            this.groupBoxRedigeraAktivitet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deltagareDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSpara1
            // 
            this.buttonSpara1.Location = new System.Drawing.Point(736, 374);
            this.buttonSpara1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSpara1.Name = "buttonSpara1";
            this.buttonSpara1.Size = new System.Drawing.Size(112, 35);
            this.buttonSpara1.TabIndex = 37;
            this.buttonSpara1.Text = "Spara";
            this.buttonSpara1.UseVisualStyleBackColor = true;
            this.buttonSpara1.Click += new System.EventHandler(this.buttonSpara1_Click);
            // 
            // buttonRedigeraAktivitet
            // 
            this.buttonRedigeraAktivitet.Location = new System.Drawing.Point(33, 374);
            this.buttonRedigeraAktivitet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRedigeraAktivitet.Name = "buttonRedigeraAktivitet";
            this.buttonRedigeraAktivitet.Size = new System.Drawing.Size(206, 35);
            this.buttonRedigeraAktivitet.TabIndex = 36;
            this.buttonRedigeraAktivitet.Text = "Välj aktivitet att redigera";
            this.buttonRedigeraAktivitet.UseVisualStyleBackColor = true;
            this.buttonRedigeraAktivitet.Click += new System.EventHandler(this.buttonRedigeraAktivitet_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(34, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 26);
            this.label4.TabIndex = 35;
            this.label4.Text = "Alla aktiviteter";
            // 
            // dataGridViewRedigeraAktivitet
            // 
            this.dataGridViewRedigeraAktivitet.AllowUserToAddRows = false;
            this.dataGridViewRedigeraAktivitet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRedigeraAktivitet.Location = new System.Drawing.Point(33, 63);
            this.dataGridViewRedigeraAktivitet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewRedigeraAktivitet.Name = "dataGridViewRedigeraAktivitet";
            this.dataGridViewRedigeraAktivitet.RowHeadersWidth = 62;
            this.dataGridViewRedigeraAktivitet.Size = new System.Drawing.Size(580, 302);
            this.dataGridViewRedigeraAktivitet.TabIndex = 34;
            // 
            // groupBoxRedigeraAktivitet
            // 
            this.groupBoxRedigeraAktivitet.Controls.Add(this.aktivitetsIdTB);
            this.groupBoxRedigeraAktivitet.Controls.Add(this.ID);
            this.groupBoxRedigeraAktivitet.Controls.Add(this.aktivitetsnamnTB);
            this.groupBoxRedigeraAktivitet.Controls.Add(this.beskrivningTB);
            this.groupBoxRedigeraAktivitet.Controls.Add(this.label3);
            this.groupBoxRedigeraAktivitet.Controls.Add(this.label2);
            this.groupBoxRedigeraAktivitet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBoxRedigeraAktivitet.Location = new System.Drawing.Point(742, 31);
            this.groupBoxRedigeraAktivitet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxRedigeraAktivitet.Name = "groupBoxRedigeraAktivitet";
            this.groupBoxRedigeraAktivitet.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxRedigeraAktivitet.Size = new System.Drawing.Size(352, 332);
            this.groupBoxRedigeraAktivitet.TabIndex = 33;
            this.groupBoxRedigeraAktivitet.TabStop = false;
            this.groupBoxRedigeraAktivitet.Text = "Redigera aktivitet";
            // 
            // aktivitetsIdTB
            // 
            this.aktivitetsIdTB.Location = new System.Drawing.Point(140, 40);
            this.aktivitetsIdTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.aktivitetsIdTB.Name = "aktivitetsIdTB";
            this.aktivitetsIdTB.ReadOnly = true;
            this.aktivitetsIdTB.Size = new System.Drawing.Size(204, 28);
            this.aktivitetsIdTB.TabIndex = 12;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(9, 40);
            this.ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ID.Name = "ID";
            this.ID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ID.Size = new System.Drawing.Size(24, 22);
            this.ID.TabIndex = 11;
            this.ID.Text = "Id";
            // 
            // aktivitetsnamnTB
            // 
            this.aktivitetsnamnTB.Location = new System.Drawing.Point(138, 78);
            this.aktivitetsnamnTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.aktivitetsnamnTB.Name = "aktivitetsnamnTB";
            this.aktivitetsnamnTB.Size = new System.Drawing.Size(204, 28);
            this.aktivitetsnamnTB.TabIndex = 1;
            // 
            // beskrivningTB
            // 
            this.beskrivningTB.Location = new System.Drawing.Point(138, 118);
            this.beskrivningTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.beskrivningTB.Name = "beskrivningTB";
            this.beskrivningTB.Size = new System.Drawing.Size(204, 28);
            this.beskrivningTB.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 122);
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
            // buttonTillbaka
            // 
            this.buttonTillbaka.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonTillbaka.Location = new System.Drawing.Point(976, 374);
            this.buttonTillbaka.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonTillbaka.Name = "buttonTillbaka";
            this.buttonTillbaka.Size = new System.Drawing.Size(112, 35);
            this.buttonTillbaka.TabIndex = 32;
            this.buttonTillbaka.Text = "Tillbaka";
            this.buttonTillbaka.UseVisualStyleBackColor = true;
            this.buttonTillbaka.Click += new System.EventHandler(this.buttonTillbaka_Click);
            // 
            // buttonTaBortAktivitet
            // 
            this.buttonTaBortAktivitet.Location = new System.Drawing.Point(448, 374);
            this.buttonTaBortAktivitet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonTaBortAktivitet.Name = "buttonTaBortAktivitet";
            this.buttonTaBortAktivitet.Size = new System.Drawing.Size(165, 35);
            this.buttonTaBortAktivitet.TabIndex = 38;
            this.buttonTaBortAktivitet.Text = "Ta bort aktivitet";
            this.buttonTaBortAktivitet.UseVisualStyleBackColor = true;
            this.buttonTaBortAktivitet.Click += new System.EventHandler(this.buttonTaBortAktivitet_Click);
            // 
            // visaDeltagareButton
            // 
            this.visaDeltagareButton.Location = new System.Drawing.Point(33, 419);
            this.visaDeltagareButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.visaDeltagareButton.Name = "visaDeltagareButton";
            this.visaDeltagareButton.Size = new System.Drawing.Size(206, 35);
            this.visaDeltagareButton.TabIndex = 39;
            this.visaDeltagareButton.Text = "Visa deltagare";
            this.visaDeltagareButton.UseVisualStyleBackColor = true;
            this.visaDeltagareButton.Click += new System.EventHandler(this.visaDeltagareButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(34, 481);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 26);
            this.label1.TabIndex = 41;
            this.label1.Text = "Deltagare";
            // 
            // deltagareDataGridView
            // 
            this.deltagareDataGridView.AllowUserToAddRows = false;
            this.deltagareDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deltagareDataGridView.Location = new System.Drawing.Point(33, 512);
            this.deltagareDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deltagareDataGridView.Name = "deltagareDataGridView";
            this.deltagareDataGridView.ReadOnly = true;
            this.deltagareDataGridView.RowHeadersWidth = 62;
            this.deltagareDataGridView.Size = new System.Drawing.Size(580, 302);
            this.deltagareDataGridView.TabIndex = 40;
            // 
            // RedigeraAktivitetPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 842);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deltagareDataGridView);
            this.Controls.Add(this.visaDeltagareButton);
            this.Controls.Add(this.buttonTaBortAktivitet);
            this.Controls.Add(this.buttonSpara1);
            this.Controls.Add(this.buttonRedigeraAktivitet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridViewRedigeraAktivitet);
            this.Controls.Add(this.groupBoxRedigeraAktivitet);
            this.Controls.Add(this.buttonTillbaka);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RedigeraAktivitetPersonal";
            this.Text = "RedigeraAktivitetPersonal";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRedigeraAktivitet)).EndInit();
            this.groupBoxRedigeraAktivitet.ResumeLayout(false);
            this.groupBoxRedigeraAktivitet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deltagareDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSpara1;
        private System.Windows.Forms.Button buttonRedigeraAktivitet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewRedigeraAktivitet;
        private System.Windows.Forms.GroupBox groupBoxRedigeraAktivitet;
        private System.Windows.Forms.TextBox aktivitetsnamnTB;
        private System.Windows.Forms.TextBox beskrivningTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonTillbaka;
        private System.Windows.Forms.Button buttonTaBortAktivitet;
        private System.Windows.Forms.TextBox aktivitetsIdTB;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Button visaDeltagareButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView deltagareDataGridView;
    }
}