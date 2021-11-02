using BusinessLayer;
using DataLayer;
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

namespace WindowsFormsApp1.GUI
{
    public partial class LäggTillAlumn : Form
    {
        BusinessManager bm = new BusinessManager();
        UnitOfWork uow { get; set; }


        SubjectButton subjectButton;
        ObserverCheckBox observerCheckBox;
        public LäggTillAlumn(UnitOfWork unitOfWork, BusinessManager businessManager)
        {
            uow = unitOfWork;
            bm = businessManager;
            InitializeComponent();

            subjectButton = new SubjectButton();
            this.Controls.Add(subjectButton);
            subjectButton.Click += läsAnvändarvillkorButton_Click;
            subjectButton.Location = läsAnvändarvillkorButton.Location;
            subjectButton.Text = läsAnvändarvillkorButton.Text;
            subjectButton.Size = läsAnvändarvillkorButton.Size;
            läsAnvändarvillkorButton.Hide();

            observerCheckBox = new ObserverCheckBox();
            this.Controls.Add(observerCheckBox);
            observerCheckBox.Location = godkännPersonuppgift.Location;
            observerCheckBox.Text = godkännPersonuppgift.Text;
            observerCheckBox.Size = godkännPersonuppgift.Size;
            godkännPersonuppgift.Hide();

            subjectButton.Register(observerCheckBox);
        }

        private void buttonSpara_Click(object sender, EventArgs e)
        {
            Alumn alumn = new Alumn();
            alumn.Namn = NamnTB.Text;
            alumn.Email = EmailTB.Text;
            alumn.Användarnamn = AnvändarnamnTB.Text;
            alumn.Lösenord = LösenordTB.Text;
            alumn.Program = programTB.Text;
            bm.LäggTillAlumn(alumn);
            MessageBox.Show("Kontot har lagts till!");
            this.Hide();
            Inloggning inloggning = new Inloggning(uow, bm);
            inloggning.ShowDialog();
            this.Close();
        }

        private void läsAnvändarvillkorButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Jag godkänner att Högskolan i Borås sparar och hanterar mina personuppgifter enligt GDPR");
            subjectButton.NotifyAll();         
        }
    }
}
