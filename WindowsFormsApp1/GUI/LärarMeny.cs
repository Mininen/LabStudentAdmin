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

namespace WindowsFormsApp1
{
    public partial class LärarMeny : Form
    {
        UnitOfWork uow { get; set; }
        BusinessManager bm { get; set; }
        public LärarMeny(UnitOfWork unitOfWork, BusinessManager bum)
        {
            InitializeComponent();
            uow = unitOfWork;
            bm = bum;         
        }

        private void buttonAktiviteter_Click(object sender, EventArgs e)
        {
            RedigeraAktivitetPersonal RedigeraAktivitetPersonal = new RedigeraAktivitetPersonal(uow, bm);
            this.Hide();
            RedigeraAktivitetPersonal.ShowDialog();
        }

        private void buttonSkapaAktiviteter_Click(object sender, EventArgs e)
        {
            SkapaAktivitet skapaAktivtetPersonal = new SkapaAktivitet(uow, bm);
            this.Hide();
            skapaAktivtetPersonal.ShowDialog();
        }

        private void buttonUtskick_Click(object sender, EventArgs e)
        {
            SkapaUtskickslista skapautskickslista = new SkapaUtskickslista (uow, bm);
            this.Hide();
            skapautskickslista.ShowDialog();
        }

        private void buttonLoggaUt_Click(object sender, EventArgs e)
        {
            Inloggning inloggning = new Inloggning(uow, bm);
            this.Hide();
            inloggning.ShowDialog();
        }
    }
}
