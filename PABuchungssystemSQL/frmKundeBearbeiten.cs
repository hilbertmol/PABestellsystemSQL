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
            SqlCommand cmd = new SqlCommand();
            string cmdStr = "";
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
                    cmd = new SqlCommand();
                    cmdStr = "";

                    if (drv.Row.RowState == DataRowState.Detached)
                    {
                        cmdStr = "insert into kunden values (@kundennr, @vorname, @nachname, @email, " +
                        "@telefon, @strasse, @hausnr, @plz, @ort)";
                    }
                    else
                    {
                        cmdStr = "update kunden set vorname = @vorname" +
                                                    ", nachname = @nachname" +
                                                    ", email = @email" +
                                                    ", telefon = @telefon" +
                                                    ", strasse = @strasse" +
                                                    ", hausnr = @hausnr" +
                                                    ", plz = @plz" +
                                                    ", ort = @ort" +
                                                    " where kundennr = @kundennr";
                    }
                    using (SqlConnection sqlConn = new SqlConnection(Helper.CnnVal("managementDB")))
                    {
                        sqlConn.Open();
                        cmd.Connection = sqlConn;
                        cmd.CommandText = cmdStr;
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@kundennr", txtKundennr.Text);
                        cmd.Parameters.AddWithValue("@vorname", txtVorname.Text);
                        cmd.Parameters.AddWithValue("@nachname", txtNachname.Text);
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                        cmd.Parameters.AddWithValue("@strasse", txtStrasse.Text);
                        cmd.Parameters.AddWithValue("@hausnr", txtHausnr.Text);
                        cmd.Parameters.AddWithValue("@plz", txtPlz.Text);
                        cmd.Parameters.AddWithValue("@ort", txtOrt.Text);
                        cmd.ExecuteNonQuery();
                    }
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
