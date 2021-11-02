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
using WindowsFormsApp1.GUI;

namespace WindowsFormsApp1
{
    public partial class Inloggning : Form
    {
        BusinessManager bm = new BusinessManager();
        UnitOfWork uow { get; set; }
        public Inloggning(UnitOfWork unitOfWork, BusinessManager businessManager)
        {
            uow = unitOfWork;
            bm = businessManager;
            InitializeComponent();
            FeedbackLB.Text = " ";
        }
        private void LoggaInStudent_Click(object sender, EventArgs e)
        {
            bool kontroll = false;
            kontroll = bm.LoggaInAlumn(SAnvändarnamn.Text, SLösenord.Text);
            if (kontroll == true)
            {
                StudentMeny sm = new StudentMeny(uow, bm);
                this.Hide();
                sm.ShowDialog();
                this.Close();
            }
            if(kontroll == false)
            {
                FeedbackLB.Text = "Fel lösenord eller användarnamn";
                FeedbackLB.ForeColor = Color.Red;
            }
        }
        private void LoggaInLärare_Click_1(object sender, EventArgs e)
        {
            bool kontroll = false;
            kontroll = bm.LoggaInPersonal(LAnvändarnamn.Text, LLösenord.Text);
            if (kontroll == true)
            {
                LärarMeny lm = new LärarMeny(uow, bm);
                this.Hide();
                lm.ShowDialog();
                this.Close();
            }
            if (kontroll == false)
            {
                FeedbackLB.Text = "Fel lösenord eller användarnamn";
                FeedbackLB.ForeColor = Color.Red;
            }
        }

        private void buttonAvsluta_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Windows.Forms.Application.Exit();
        }

        private void skapaAlumnKontoButton_Click(object sender, EventArgs e)
        {
            LäggTillAlumn läggTillAlumn = new LäggTillAlumn(uow, bm);
            this.Hide();
            läggTillAlumn.ShowDialog();
            this.Close();
        }
    }
}
