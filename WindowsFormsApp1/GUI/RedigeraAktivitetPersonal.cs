using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using DataLayer;
using BusinessEntities;

namespace WindowsFormsApp1
{
    public partial class RedigeraAktivitetPersonal : Form
    {

        BindingSource bindingSource = new BindingSource();
        BusinessManager bm { get; set; }
        UnitOfWork uow { get; set; }
        public RedigeraAktivitetPersonal(UnitOfWork unitOfWork, BusinessManager businessManager)
        {
            uow = unitOfWork;
            bm = businessManager;
            InitializeComponent();
            HämtaAktiviteter();         
        }

        private void buttonRedigeraAktivitet_Click(object sender, EventArgs e)
        {
            FyllTextboxMedInfo();
        }

        private void buttonSpara1_Click(object sender, EventArgs e)
        {
            Aktivitet redigeradAktivitet = new Aktivitet();
            redigeradAktivitet.Aktivitetsnamn = aktivitetsnamnTB.Text;
            redigeradAktivitet.Beskrivning = beskrivningTB.Text;

            string aktivitetsIdstring = aktivitetsIdTB.Text;

            redigeradAktivitet.AktivitetId = Convert.ToInt32(aktivitetsIdstring);

            bm.RedigeraAktivitet(redigeradAktivitet);
            MessageBox.Show("Ändringarna har sparats!");
      
            dataGridViewRedigeraAktivitet.DataSource = null;
            List<Aktivitet> x = bm.HämtaAktiviteter();
            dataGridViewRedigeraAktivitet.DataSource = x;
            dataGridViewRedigeraAktivitet.Columns["Alumns"].Visible = false;
        }

        private void buttonTaBortAktivitet_Click(object sender, EventArgs e)
        {
            string aktivitetsIdstring = dataGridViewRedigeraAktivitet.CurrentCell.Value.ToString();
            int aktivitetsId = Convert.ToInt32(aktivitetsIdstring);
            bm.TaBortAktivitet(aktivitetsId);

            dataGridViewRedigeraAktivitet.DataSource = null;
            List<Aktivitet> x = bm.HämtaAktiviteter();
            dataGridViewRedigeraAktivitet.DataSource = x;
            dataGridViewRedigeraAktivitet.Columns["Alumns"].Visible = false;
        }

        private void visaDeltagareButton_Click(object sender, EventArgs e)
        {
            string aktivitetsIdstring = dataGridViewRedigeraAktivitet.CurrentCell.Value.ToString();
            int aktivitetsId = Convert.ToInt32(aktivitetsIdstring);

            deltagareDataGridView.DataSource = bm.HittaRegistreradeAlumner(aktivitetsId);
            deltagareDataGridView.Columns["Användarnamn"].Visible = false;
            deltagareDataGridView.Columns["Lösenord"].Visible = false;
            deltagareDataGridView.Columns["Aktiviter"].Visible = false;
            deltagareDataGridView.Columns["Utskicks"].Visible = false;
            deltagareDataGridView.Columns["Inloggad"].Visible = false;

        }

        private void buttonTillbaka_Click(object sender, EventArgs e)
        {
            LärarMeny pm = new LärarMeny(uow, bm);
            this.Hide();
            pm.ShowDialog();
            this.Close();
        }

        public void FyllTextboxMedInfo()
        {
            int aktivitetsId = (int)dataGridViewRedigeraAktivitet.CurrentCell.Value;
            Aktivitet aktivitet = bm.HämtaAktivitetviaID(aktivitetsId);
            aktivitetsIdTB.Text = aktivitet.AktivitetId.ToString();
            aktivitetsnamnTB.Text = aktivitet.Aktivitetsnamn;
            beskrivningTB.Text = aktivitet.Beskrivning;
        }

        public void HämtaAktiviteter()
        {
            dataGridViewRedigeraAktivitet.DataSource = bm.HämtaAktiviteter();
            dataGridViewRedigeraAktivitet.Columns["Alumns"].Visible = false;
        }




    }
}
