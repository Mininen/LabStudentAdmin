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
using BusinessLayer;
using BusinessEntities;

namespace WindowsFormsApp1
{
    public partial class StudentMeny : Form
    {
        UnitOfWork uow { get; set; }
        BusinessManager bm { get; set; }
        public StudentMeny(UnitOfWork unitOfWork, BusinessManager businessManager)
        {
            InitializeComponent();
            uow = unitOfWork;
            bm = businessManager;
        }

        private void redigeraProfil_Click(object sender, EventArgs e)
        {
            RedigeraStudentProfil redigeraStudentProfil = new RedigeraStudentProfil(uow, bm);
            this.Hide();
            redigeraStudentProfil.ShowDialog();
        }

        private void Aktivitetsanmälan_Click(object sender, EventArgs e)
        {
            StudentAktiviteter studentAktiviteter = new StudentAktiviteter(uow, bm);
            this.Hide();
            studentAktiviteter.ShowDialog();
        }

        private void buttonLoggaUt_Click(object sender, EventArgs e)
        {
            Alumn inloggadAlumn = bm.HämtaInloggadAlumn();
            bm.LoggautAlumn(inloggadAlumn);
            Inloggning inloggning = new Inloggning(uow, bm);
            this.Hide();
            inloggning.ShowDialog();
        }
    }
}
