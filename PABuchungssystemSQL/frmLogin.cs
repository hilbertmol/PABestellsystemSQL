using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PABuchungssystemSQL
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sqlDa = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            string cmdStr = "";

            using (SqlConnection sqlConn = new SqlConnection(Helper.CnnVal("loginDB")))
            {
                cmdStr = "select * from userdata where login = @login collate latin1_general_cs_as and passwort = @passwort " +
                    "collate latin1_general_cs_as";
                cmd = new SqlCommand(cmdStr, sqlConn);
                cmd.Parameters.AddWithValue("@login", txtLogin.Text);
                cmd.Parameters.AddWithValue("@passwort", txtPassword.Text);
                sqlDa.SelectCommand = cmd;
                dt = new DataTable();
                sqlDa.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    //frmKunden frmK = new frmKunden();
                    //frmK.Show();
                    frmBestellungen frmB= new frmBestellungen();
                    frmB.Show();
                    //frmProdukte frmP = new frmProdukte();
                    //frmP.Show();
                    //frmUebersicht frmU = new frmUebersicht();
                    //frmU.Show();
                    //frmBenutzerverwaltung frmBV = new frmBenutzerverwaltung();
                    //frmBV.Show();
                }
                else
                {
                    MessageBox.Show("Ungültige Login / Passwort.", "Information");
                }
            }
        }

        private void btnBeenden_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkbPasswortEinblenden_CheckedChanged(object sender, EventArgs e)
        {
            if(chkbPasswortEinblenden.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }
    }
}
