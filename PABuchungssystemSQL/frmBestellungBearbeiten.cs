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
            SqlCommand cmd = new SqlCommand();
            string cmdStr = "";
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
                    cmd = new SqlCommand();
                    cmdStr = "";

                    if (drv.Row.RowState == DataRowState.Detached)
                    {
                        cmdStr = "insert into bestellungen values (@bestellungsnr, @kundennr, @produktnr, @datum)";
                    }
                    else
                    {
                        cmdStr = "update bestellungen set kundennr = @kundennr" +
                                                    ", produktnr = @produktnr" +
                                                    ", datum = @datum" +
                                                    " where bestellungsnr = @bestellungsnr";
                    }
                    using (SqlConnection sqlConn = new SqlConnection(Helper.CnnVal("managementDB")))
                    {
                        sqlConn.Open();
                        cmd.Connection = sqlConn;
                        cmd.CommandText = cmdStr;
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@bestellungsnr", txtBestellungsnr.Text);
                        cmd.Parameters.AddWithValue("@kundennr", txtKundennr.Text);
                        cmd.Parameters.AddWithValue("@produktnr", txtProduktnr.Text);
                        cmd.Parameters.AddWithValue("@datum", txtDatum.Text);
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
