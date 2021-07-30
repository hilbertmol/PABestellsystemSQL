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

namespace PABestellsystemSQL
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
                    Login.BenutzerAktuell = txtLogin.Text;
                    Login.KontoTyp = GetKontoTyp(txtLogin.Text);
                    this.Hide();
                    frmHauptmenue fH = new frmHauptmenue();
                    if (!FormCheckOpened(fH.Name))
                    { 
                        fH.Show();
                    }
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
            if (chkbPasswortEinblenden.Checked)
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

        private bool FormCheckOpened(string name)
        {
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                if (frm.Name == name)
                {
                    return true;
                }
            }
            return false;
        }

        private string GetKontoTyp(string login)
        {
            SqlCommand cmd = new SqlCommand();

            try
            {
                using (SqlConnection sqlConn = new SqlConnection(Helper.CnnVal("loginDB")))
                {
                    sqlConn.Open();
                    cmd = new SqlCommand("select typ from userdata where login = @login", sqlConn);
                    cmd.Parameters.AddWithValue("@login", login);
                    string kontoTyp = (string)cmd.ExecuteScalar();
                    return kontoTyp;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "";
            }
        }
    }
}
