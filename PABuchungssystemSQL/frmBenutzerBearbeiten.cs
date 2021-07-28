using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PABuchungssystemSQL
{
    public partial class frmBenutzerBearbeiten : Form
    {
        public frmBenutzerBearbeiten()
        {
            InitializeComponent();
            GetDataCBox();
            txtPasswort.PasswordChar = '*';
            txtPasswortW.PasswordChar = '*';
        }

        public void EditBenutzer(DataRowView drv)
        {
            SqlCommand cmd = new SqlCommand();
            string cmdStr = "";
            try
            {
                if (drv.Row.RowState == DataRowState.Detached)
                {
                    txtLogin.Text = "";
                    txtPasswort.Text = "";
                    txtPasswortW.Text = "";
                    txtVorname.Text = "";
                    txtNachname.Text = "";
                    txtEmail.Text = "";
                    cmbKontotyp.SelectedItem = "";
                }
                else
                {
                    txtLogin.Text = drv["login"].ToString(); ;
                    txtPasswort.Text = drv["passwort"].ToString();
                    txtPasswortW.Text = drv["passwort"].ToString();
                    txtVorname.Text = drv["vorname"].ToString();
                    txtNachname.Text = drv["nachname"].ToString();
                    txtEmail.Text = drv["email"].ToString();
                    cmbKontotyp.SelectedItem = drv["typ"].ToString();
                }

                if (this.ShowDialog() == DialogResult.OK)
                {
                    cmd = new SqlCommand();
                    cmdStr = "";

                    if (drv.Row.RowState == DataRowState.Detached)
                    {
                        cmdStr = "insert into userdata values (@login, @passwort, @vorname, @nachname, " +
                        "@email, @typ)";
                    }
                    else
                    {
                        cmdStr = "update userdata set passwort = @passwort" +
                                                    ", vorname = @vorname" +
                                                    ", nachname = @nachname" +
                                                    ", email = @email" +
                                                    ", typ = @typ" +
                                                    " where login = @login";
                    }
                    using (SqlConnection sqlConn = new SqlConnection(Helper.CnnVal("loginDB")))
                    {
                        sqlConn.Open();
                        cmd.Connection = sqlConn;
                        cmd.CommandText = cmdStr;
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@login", txtLogin.Text);
                        cmd.Parameters.AddWithValue("@passwort", txtPasswort.Text);
                        cmd.Parameters.AddWithValue("@vorname", txtVorname.Text);
                        cmd.Parameters.AddWithValue("@nachname", txtNachname.Text);
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@typ", cmbKontotyp.SelectedItem.ToString());
                        cmd.ExecuteNonQuery();
                    }
                }
                else
                {
                    drv.CancelEdit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetDataCBox()
        {
            SqlDataAdapter sqlDa = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            string cmdStr = "";
            string typ = "";

            try
            {
                using (SqlConnection sqlConn = new SqlConnection(Helper.CnnVal("loginDB")))
                {
                    sqlConn.Open();
                    cmdStr = "select typ from userdata";
                    cmd = new SqlCommand(cmdStr, sqlConn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        typ = reader["typ"].ToString();
                        if (!cmbKontotyp.Items.Contains(typ))
                            cmbKontotyp.Items.Add(typ);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtPasswort.Text == txtPasswortW.Text)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Passwort nicht gleich.");
            }
        }

        private void btnAbbrechen_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void chkbPasswortEinblenden_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbPasswortEinblenden.Checked)
            {
                txtPasswort.PasswordChar = '\0';
                txtPasswortW.PasswordChar = '\0';
            }
            else
            {
                txtPasswort.PasswordChar = '*';
                txtPasswortW.PasswordChar = '*';
            }
        }
    }
}
