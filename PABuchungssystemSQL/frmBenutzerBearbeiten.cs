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
        }

        public void EditBenutzer(DataRowView drv)
        {
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
                    string sqlCmd = "";
                    if (drv.Row.RowState == DataRowState.Detached)
                    {
                        sqlCmd = "insert into userdata values ('" + txtLogin.Text + "'" +
                                                            ", '" + txtPasswort.Text + "'" +
                                                            ", '" + txtVorname.Text + "'" +
                                                            ", '" + txtNachname.Text + "'" +
                                                            ", '" + txtEmail.Text + "'" +
                                                            ", '" + cmbKontotyp.SelectedItem.ToString() + "')";

                    }
                    else
                    {
                        sqlCmd = "update userdata set passwort = '" + txtPasswort.Text + "' " +
                                                        ", vorname = '" + txtVorname.Text + "' " +
                                                        ", nachname = '" + txtNachname.Text + "' " +
                                                        ", email = '" + txtEmail.Text + "' " +
                                                        ", typ = '" + cmbKontotyp.SelectedItem.ToString() + "' " +
                                                        "where login = '" + txtLogin.Text + "'";
                    }
                    using (SqlConnection sqlConn = new SqlConnection(Helper.CnnVal("loginDB")))
                    {
                        sqlConn.Open();
                        SqlDataAdapter sqlDa = new SqlDataAdapter(sqlCmd, sqlConn);
                        DataTable dt = new DataTable();
                        sqlDa.Fill(dt);
                    }
                    drv["login"] = txtLogin.Text; ;
                    drv["passwort"] = txtPasswort.Text;
                    drv["vorname"] = txtVorname.Text;
                    drv["nachname"] = txtNachname.Text;
                    drv["email"] = txtEmail.Text;
                    drv["typ"] = cmbKontotyp.SelectedItem;
                    drv.EndEdit();
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
            DialogResult = DialogResult.OK;
        }

        private void btnAbbrechen_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
