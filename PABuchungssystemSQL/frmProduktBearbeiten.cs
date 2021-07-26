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
    public partial class frmProduktBearbeiten : Form
    {
        public frmProduktBearbeiten()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        public void EditProdukt(DataRowView drv)
        {
            try
            {
                if (drv.Row.RowState == DataRowState.Detached)
                {
                    txtProduktnr.Text = "";
                    txtProduktname.Text = "";
                    txtPreis.Text = "";
                    txtBeschreibung.Text = "";
                    txtHersteller.Text = "";
                    txtKategorie.Text = "";
                    txtStueckzahl.Text = "";
                }
                else
                {
                    txtProduktnr.Text = drv["produktnr"].ToString();
                    txtProduktname.Text = drv["produktname"].ToString();
                    txtPreis.Text = drv["preis"].ToString();
                    txtBeschreibung.Text = drv["beschreibung"].ToString();
                    txtHersteller.Text = drv["hersteller"].ToString();
                    txtKategorie.Text = drv["kategorie"].ToString();
                    txtStueckzahl.Text = drv["stueckzahl"].ToString();
                }

                if (this.ShowDialog() == DialogResult.OK)
                {
                    string sqlCmd = "";
                    double preis = Convert.ToDouble(txtPreis.Text);
                    string preisStr = (String.Format("{0:0.00}", preis)).Replace(',', '.');

                if (drv.Row.RowState == DataRowState.Detached)
                    {
                        sqlCmd = "insert into produkte values ('" + txtProduktnr.Text + "'" +
                                                            ", '" + txtProduktname.Text + "'" +
                                                            ", '" + preisStr + "'" +
                                                            ", '" + txtBeschreibung.Text + "'" +
                                                            ", '" + txtHersteller.Text + "'" +
                                                            ", '" + txtKategorie.Text + "'" +
                                                            ", '" + txtStueckzahl.Text + "')";
                    }
                    else
                    {
                        sqlCmd = "update produkte set produktname = '" + txtProduktname.Text + "' " +
                                                ", preis = '" + preisStr + "' " +
                                                ", beschreibung = '" + txtBeschreibung.Text + "' " +
                                                ", hersteller = '" + txtHersteller.Text + "' " +
                                                ", kategorie = '" + txtKategorie.Text + "' " +
                                                ", stueckzahl = '" + txtStueckzahl.Text + "' " +
                                                "where produktnr = '" + txtProduktnr.Text + "'";
                    }
                    using (SqlConnection sqlConn = new SqlConnection(Helper.CnnVal("managementDB")))
                    {
                        sqlConn.Open();
                        SqlDataAdapter sqlDa = new SqlDataAdapter(sqlCmd, sqlConn);
                        DataTable dt = new DataTable();
                        sqlDa.Fill(dt);
                    }
                    drv.BeginEdit();
                    drv["produktnr"] = txtProduktnr.Text;
                    drv["produktname"] = txtProduktname.Text;
                    drv["preis"] = txtPreis.Text;
                    drv["beschreibung"] = txtBeschreibung.Text;
                    drv["hersteller"] = txtHersteller.Text;
                    drv["kategorie"] = txtKategorie.Text;
                    drv["stueckzahl"] = txtStueckzahl.Text;
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

        private void btnAbbrechen_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
