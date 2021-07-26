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
    public partial class frmKundeBearbeiten : Form
    {
        public frmKundeBearbeiten()
        {
            InitializeComponent();            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        public void EditKunde(DataRowView drv)
        {
            try
            {
                if (drv.Row.RowState == DataRowState.Detached)
                {
                    txtKundennr.Text = "";
                    txtVorname.Text = "";
                    txtNachname.Text = "";
                    txtEmail.Text = "";
                    txtTelefon.Text = "";
                    txtStrasse.Text = "";
                    txtHausnr.Text = "";
                    txtPlz.Text = "";
                    txtOrt.Text = "";
                }
                else
                {
                    txtKundennr.Text = drv["kundennr"].ToString();
                    txtVorname.Text = drv["vorname"].ToString();
                    txtNachname.Text = drv["nachname"].ToString();
                    txtEmail.Text = drv["email"].ToString();
                    txtTelefon.Text = drv["telefon"].ToString();
                    txtStrasse.Text = drv["strasse"].ToString();
                    txtHausnr.Text = drv["hausnr"].ToString();
                    txtPlz.Text = drv["plz"].ToString();
                    txtOrt.Text = drv["ort"].ToString();
                }

                if (this.ShowDialog() == DialogResult.OK)
                {
                    string sqlCmd = "";
                    if (drv.Row.RowState == DataRowState.Detached)
                    {
                        sqlCmd = "insert into kunden values ('" + txtKundennr.Text + "'" +
                                                            ", '" + txtVorname.Text + "'" +
                                                            ", '" + txtNachname.Text + "'" +
                                                            ", '" + txtEmail.Text + "'" +
                                                            ", '" + txtTelefon.Text + "'" +
                                                            ", '" + txtStrasse.Text + "'" +
                                                            ", '" + txtHausnr.Text + "'" +
                                                            ", '" + txtPlz.Text + "'" +
                                                            ", '" + txtOrt.Text + "')";

                    }
                    else
                    {
                        sqlCmd = "update kunden set vorname = '" + txtVorname.Text + "' " +
                                                ", nachname = '" + txtNachname.Text + "' " +
                                                ", email = '" + txtEmail.Text + "' " +
                                                ", telefon = '" + txtTelefon.Text + "' " +
                                                ", strasse = '" + txtStrasse.Text + "' " +
                                                ", hausnr = '" + txtHausnr.Text + "' " +
                                                ", plz = '" + txtPlz.Text + "' " +
                                                ", ort = '" + txtOrt.Text + "' " +
                                                "where kundennr = '" + txtKundennr.Text + "'";
                    }
                    using (SqlConnection sqlConn = new SqlConnection(Helper.CnnVal("managementDB")))
                    {
                        sqlConn.Open();
                        SqlDataAdapter sqlDa = new SqlDataAdapter(sqlCmd, sqlConn);
                        DataTable dt = new DataTable();
                        sqlDa.Fill(dt);
                        sqlConn.Close();
                    }
                    drv.BeginEdit();
                    drv["kundennr"] = txtKundennr.Text;
                    drv["vorname"] = txtVorname.Text;
                    drv["nachname"] = txtNachname.Text;
                    drv["email"] = txtEmail.Text;
                    drv["telefon"] = txtTelefon.Text;
                    drv["strasse"] = txtStrasse.Text;
                    drv["hausnr"] = txtHausnr.Text;
                    drv["plz"] = txtPlz.Text;
                    drv["ort"] = txtOrt.Text;
                    drv.EndEdit();
                }
                else
                {
                    drv.CancelEdit();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAbbrechen_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
