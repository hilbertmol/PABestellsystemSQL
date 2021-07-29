using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PABestellsystemSQL
{
    public partial class frmHauptmenue : Form
    {
        public frmHauptmenue()
        {
            InitializeComponent();
            lblBenutzeraktuell.Text = Login.BenutzerAktuell;
        }

        private void btnBeenden_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEinloggen_Click(object sender, EventArgs e)
        {
            frmLogin fL = new frmLogin();
            fL.Show();
        }

        private void btnBestellungen_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBestellungen frmB = new frmBestellungen();
            frmB.Show();
        }

        private void btnKunden_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmKunden frmK = new frmKunden();
            frmK.Show();
        }

        private void btnProdukte_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmProdukte frmP = new frmProdukte();
            frmP.Show();
        }

        private void btnUebersicht_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUebersicht frmU = new frmUebersicht();
            frmU.Show();
        }

        private void btnBenutzerverwaltung_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBenutzerverwaltung frmBV = new frmBenutzerverwaltung();
            frmBV.Show();
        }

        private void frmHauptmenue_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnAusloggen_Click(object sender, EventArgs e)
        {
            Login.BenutzerAktuell = "";
            Login.KontoTyp = "";
            lblBenutzeraktuell.Text = Login.BenutzerAktuell;
            btnBenutzerverwaltung.Enabled = false;
        }

        private void frmHauptmenue_Activated(object sender, EventArgs e)
        {
            lblBenutzeraktuell.Text = Login.BenutzerAktuell;
            if (Login.KontoTyp != "admin")
            {
                btnBenutzerverwaltung.Enabled = false;
            }
            else
            {
                btnBenutzerverwaltung.Enabled = true;
            }
        }
    }
}
