using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;
using BusinessEntities;
using BusinessLayer;

namespace WindowsFormsApp1
{
    public partial class StudentAktiviteter : Form
    {
        UnitOfWork uow { get; set; }
        BusinessManager bm { get; set; }        
        public StudentAktiviteter(UnitOfWork unitOfWork, BusinessManager businessManager)
        {
            uow = unitOfWork;
            bm = businessManager;
            InitializeComponent();
            HämtaAktiviteterTillGridView();
        }

        public void HämtaAktiviteterTillGridView()
        {
            DataGridViewStudentAktiviteter.DataSource = bm.HämtaAktiviteter();
            DataGridViewStudentAktiviteter.Columns["Alumns"].Visible = false;
        }

        private void buttonAnmäl_Click(object sender, EventArgs e)
        {
            Aktivitet valdAktivitet = (Aktivitet)DataGridViewStudentAktiviteter.CurrentRow.DataBoundItem;
            Alumn inloggadAlum = bm.HämtaInloggadAlumn();
            MessageBox.Show("Du är registrerad till aktivitet: " + valdAktivitet.AktivitetId + " " + valdAktivitet.Aktivitetsnamn);
            bm.RegistreraAlumnTillAktivitet(inloggadAlum, valdAktivitet);

            dataGridViewMinaAktiviteter.DataSource = null;
            List<Aktivitet> alumnAktiviteter = bm.HämtaAlumnAktiviteter(inloggadAlum);
            dataGridViewMinaAktiviteter.DataSource = alumnAktiviteter;
            dataGridViewMinaAktiviteter.Columns["Alumns"].Visible = false;
        }

        private void buttonTillbaka_Click(object sender, EventArgs e)
        {
            StudentMeny pm = new StudentMeny(uow, bm);
            this.Hide();
            pm.ShowDialog();
            this.Close();
        }
    }
}
