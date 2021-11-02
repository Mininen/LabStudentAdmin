using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessEntities;
using BusinessLayer;
using DataLayer;

namespace WindowsFormsApp1
{
    public partial class SkapaAktivitet : Form
    {
        UnitOfWork uow { get; set; }
        BusinessManager bm { get; set; }
        public SkapaAktivitet(UnitOfWork unit, BusinessManager bus)
        {
            uow = unit;
            bm = bus;
            InitializeComponent();
        }

        private void buttonSkapa_Click(object sender, EventArgs e)
        {
            Aktivitet nyAktivitet = new Aktivitet();
            nyAktivitet.Aktivitetsnamn = NamnTB.Text;
            nyAktivitet.Beskrivning = BeskrivningTB.Text;
            bm.SkapaAktivitet(nyAktivitet);

            MessageBox.Show("Aktiviteten har lagts till");
            SkapaAktivitet lm = new SkapaAktivitet(uow, bm);
            this.Hide();
            lm.ShowDialog();
        }

        private void buttonTillbaka_Click(object sender, EventArgs e)
        {
            LärarMeny lm = new LärarMeny(uow, bm);
            this.Hide();
            lm.ShowDialog();
        }
    }
}
