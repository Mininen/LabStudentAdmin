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
using WindowsFormsApp1.GUI;

namespace WindowsFormsApp1
{
    public partial class RedigeraStudentProfil : Form
    {
        UnitOfWork uow { get; set; }
        BusinessManager bm { get; set; }

        public RedigeraStudentProfil(UnitOfWork unitOfWork, BusinessManager businessManager)
        {
            uow = unitOfWork;
            bm = businessManager;
            InitializeComponent();
            FyllTextboxMedInfo();
        }

        private void buttonSpara_Click(object sender, EventArgs e)
        {
            Alumn redigeradAlumn = new Alumn();
            redigeradAlumn.Namn = NamnTB.Text;
            redigeradAlumn.Email = EmailTB.Text;
            redigeradAlumn.Användarnamn = AnvändarnamnTB.Text;
            redigeradAlumn.Lösenord = LösenordTB.Text;
            bm.RedigeraAlum(redigeradAlumn);
            MessageBox.Show("Ändringarna har sparats!");
        }

        public void FyllTextboxMedInfo()
        {
            Alumn alumn = bm.HämtaInloggadAlumn();
            NamnTB.Text = alumn.Namn;
            EmailTB.Text = alumn.Email;
            AnvändarnamnTB.Text = alumn.Användarnamn;
            LösenordTB.Text = alumn.Lösenord;
        }

        private void buttonTillbaka_Click(object sender, EventArgs e)
        {
            StudentMeny sm = new StudentMeny(uow, bm);
            this.Hide();
            sm.ShowDialog();
            this.Close();
        }

        private void taBortKontoButton_Click(object sender, EventArgs e)
        {
            Alumn alumn = bm.HämtaInloggadAlumn();
            bm.TaBortAlumnKonto(alumn);
            MessageBox.Show("Ditt konto är borttaget");

            Inloggning inloggning = new Inloggning (uow, bm);
            this.Hide();
            inloggning.ShowDialog();
            this.Close();

        }
    }
}
