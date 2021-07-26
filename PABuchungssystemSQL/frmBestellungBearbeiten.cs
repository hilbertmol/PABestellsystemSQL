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
    public partial class frmBestellungBearbeiten : Form
    {
        public frmBestellungBearbeiten()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        public void EditBestellung(DataRowView drv)
        {
            try
            {
                if (drv.Row.RowState == DataRowState.Detached)
                {
                    txtBestellungsnr.Text = "";
                    txtKundennr.Text = "";
                    txtProduktnr.Text = "";
                    txtDatum.Text = "";
                }
                else
                {
                    txtBestellungsnr.Text = drv["bestellungsnr"].ToString();
                    txtKundennr.Text = drv["kundennr"].ToString();
                    txtProduktnr.Text = drv["produktnr"].ToString();
                    txtDatum.Text = drv["datum"].ToString();
                }

                if (this.ShowDialog() == DialogResult.OK)
                {
                    string sqlCmd = "";
                    if (drv.Row.RowState == DataRowState.Detached)
                    {
                        sqlCmd = "insert into bestellungen values ('" + txtBestellungsnr.Text + "'" +
                                                            ", '" + txtKundennr.Text + "'" +
                                                            ", '" + txtProduktnr.Text + "'" +
                                                            ", '" + txtDatum.Text + "')";

                    }
                    else
                    {
                        sqlCmd = "update bestellungen set kundennr = '" + txtKundennr.Text + "' " +
                                                ", produktnr = '" + txtProduktnr.Text + "' " +
                                                ", datum = '" + txtDatum.Text + "' " +
                                                "where bestellungsnr = '" + txtBestellungsnr.Text + "'";
                    }
                    using (SqlConnection sqlConn = new SqlConnection(Helper.CnnVal("managementDB")))
                    {
                        sqlConn.Open();
                        SqlDataAdapter sqlDa = new SqlDataAdapter(sqlCmd, sqlConn);
                        DataTable dt = new DataTable();
                        sqlDa.Fill(dt);
                    }
                    drv.BeginEdit();
                    drv["bestellungsnr"] = txtBestellungsnr.Text;
                    drv["kundennr"] = txtKundennr.Text;
                    drv["produktnr"] = txtProduktnr.Text;
                    drv["datum"] = txtDatum.Text;
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

        private void dtpBestellung_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = dtpBestellungDate.Value.Date + dtpBestellungTime.Value.TimeOfDay;
            txtDatum.Text = dt.ToString("dd.MM.yyyy HH:mm:ss");
        }
    }
}
