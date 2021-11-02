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
    public partial class SkapaUtskickslista : Form
    {
        UnitOfWork uow { get; set; }
        BusinessManager bm { get; set; }

        public SkapaUtskickslista(UnitOfWork unitOfWork, BusinessManager businessManager)
        {
            uow = unitOfWork;
            bm = businessManager;
            InitializeComponent();
            FyllGridView();
           
        }

        //Tillbaka knapp
        private void button2_Click(object sender, EventArgs e)
        {
            LärarMeny pm = new LärarMeny(uow, bm);
            this.Hide();
            pm.ShowDialog();
            this.Close();
        }

        //Skapa nytt utskick
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridViewUtskickslistor.DataSource = null;

            List<Alumn> mottagare = HittaMottagare();
            Utskick utskick = new Utskick();
            utskick.Utskicksnamn = namnTB.Text;
            utskick.Innehåll = innehållTB.Text;
            utskick.Alumns = mottagare;

            bm.SkapaUtskick(utskick);
            FyllGridView();
            namnTB.Clear();
            innehållTB.Clear();    
        }

        private void buttonSpara_Click(object sender, EventArgs e)
        {
            Utskick redigeradUtskick = new Utskick();
            string idString = dataGridViewUtskickslistor.CurrentCell.Value.ToString();
            int utskicksid = Convert.ToInt32(idString);
            redigeradUtskick.Utskicksnamn = namnTB.Text;
            redigeradUtskick.Innehåll = innehållTB.Text;
            redigeradUtskick.UtskickId = utskicksid;            
            bm.RedigeraUtskick(redigeradUtskick);

            if(checkedListBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Ingen almun tas bort");
            }
            else 
            {
                string alumnIDs = checkedListBox1.SelectedItem.ToString();
                int alumnId = Convert.ToInt32(alumnIDs);
                bm.TaBortMottagare(utskicksid, alumnId);
                checkedListBox1.Items.Clear();
                FyllListBox1();
            }

            if(checkedListBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Ingen alumn läggs till");
            }
            else
            {
                string alumnIDs = checkedListBox2.SelectedItem.ToString();
                int alumnId = Convert.ToInt32(alumnIDs);
                bm.LäggTillMottagare(utskicksid, alumnId);
                checkedListBox2.Items.Clear();
                FyllListBox2();
            }

            MessageBox.Show("Ändringarna har sparats!");
            dataGridViewUtskickslistor.DataSource = null;
            FyllGridView();
            FyllMottagarDataGrid();
            namnTB.Clear();
            innehållTB.Clear();
            checkedListBox2.Items.Clear();
        }

        private void buttonRedigeraUtskick_Click(object sender, EventArgs e)
        {
            string idString = dataGridViewUtskickslistor.CurrentCell.Value.ToString();
            int id = Convert.ToInt32(idString);
            FyllTextboxMedInfo(id);
            FyllMottagarDataGrid();
            checkedListBox1.Items.Clear();
            checkedListBox2.Items.Clear();

            FyllListBox1();
            FyllListBox2();
        }

        //Hitta mottagare till utskickslistor
        public List<Alumn> HittaMottagare()
        {
            List<Alumn> mottagare = null;
            if (systemvetareRB.Checked == true)
            {
                mottagare = bm.HämtaSystemvetare();
            }
            else if (systemarkitekterRB.Checked == true)
            {
                mottagare = bm.HämtaSystemarkitekter();
            }
            else if (dataekonomerRB.Checked == true)
            {
                mottagare = bm.HämtaDataekonomer();
            }
            else if (allaAlumnerRB.Checked == true)
            {
                mottagare = bm.HämtaAlumner();
            }

            return mottagare;
        }

        public void FyllGridView()
        {
            dataGridViewUtskickslistor.DataSource = bm.HämtaUtskickListor();
            dataGridViewUtskickslistor.Columns["Alumns"].Visible = false;
        }

        public void FyllTextboxMedInfo(int utskicksId)
        {
            Utskick utskick = bm.HämtaUtskicksID(utskicksId);
            namnTB.Text = utskick.Utskicksnamn;
            innehållTB.Text = utskick.Innehåll;
        }

        private void taBortButton_Click(object sender, EventArgs e)
        {
            string idString = dataGridViewUtskickslistor.CurrentCell.Value.ToString();
            int id = Convert.ToInt32(idString);
            bm.TaBortUtskick(id);

            dataGridViewUtskickslistor.DataSource = null;
            FyllGridView();
        }
        private void FyllMottagarDataGrid()
        {
            dataGridViewMottagare.DataSource = null;
            string idString = dataGridViewUtskickslistor.CurrentCell.Value.ToString();
            int id = Convert.ToInt32(idString);
            dataGridViewMottagare.DataSource = bm.HämtaMottagare(id);
            dataGridViewMottagare.Columns["Användarnamn"].Visible = false;
            dataGridViewMottagare.Columns["Lösenord"].Visible = false;
            dataGridViewMottagare.Columns["Aktiviter"].Visible = false;
            dataGridViewMottagare.Columns["Utskicks"].Visible = false;
            dataGridViewMottagare.Columns["Inloggad"].Visible = false;
        }
        public void FyllListBox1()
        {
            string idString = dataGridViewUtskickslistor.CurrentCell.Value.ToString();
            int id = Convert.ToInt32(idString);
            List<Alumn> mottagare = bm.HämtaMottagare(id);
            foreach (Alumn alumn in mottagare)
            {
                checkedListBox1.Items.Add(alumn.AlumnId);
            }
        }
        public void FyllListBox2()
        {
            List<Alumn> alumner = bm.HämtaAlumner();
            foreach (Alumn alumn in alumner)
            {
                checkedListBox2.Items.Add(alumn.AlumnId);
            }
        }
    }
}
