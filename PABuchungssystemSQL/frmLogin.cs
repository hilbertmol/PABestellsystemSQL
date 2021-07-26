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
            SqlConnection sqlConn = new SqlConnection(Helper.CnnVal("loginDB"));
            string sqlCmd = "select * from userdata where login = '" + txtLogin.Text.Trim() + "' " +
                "and password = '" + txtPassword.Text.Trim() + "'";
            SqlDataAdapter sqlDa = new SqlDataAdapter(sqlCmd, sqlConn);
            DataTable dt = new DataTable();
            sqlDa.Fill(dt);

            if(dt.Rows.Count == 1)
            {
                this.Hide();
                //frmKunden frmK = new frmKunden();
                //frmK.Show();
                //frmBestellungen frmB= new frmBestellungen();
                //frmB.Show();
                //frmProdukte frmP = new frmProdukte();
                //frmP.Show();
                frmUebersicht frmU = new frmUebersicht();
                frmU.Show();
            }
            else
            {
                MessageBox.Show("Ungültige Login / Passwort", "Information");
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
