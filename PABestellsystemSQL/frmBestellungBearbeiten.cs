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

namespace PABestellsystemSQL
{
    public partial class frmBestellungBearbeiten : Form
    {
        public frmBestellungBearbeiten()
        {
            InitializeComponent();
        }

        private string produktnrAlt = "";

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
                    produktnrAlt = txtProduktnr.Text;
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
                    UpdateStueckzahlAdd(produktnrAlt, GetStueckzahl(produktnrAlt));
                    UpdateStueckzahlSub(txtProduktnr.Text, GetStueckzahl(txtProduktnr.Text));
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

        private int GetStueckzahl(string produktnr)
        {
            SqlCommand cmd = new SqlCommand();
            string cmdStr = "";
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(Helper.CnnVal("managementDB")))
                {
                    sqlConn.Open();
                    cmd.Connection = sqlConn;
                    cmdStr = "select stueckzahl from produkte where produktnr = @produktnr";
                    cmd.CommandText = cmdStr;
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@produktnr", produktnr);
                    int cnt = (int)cmd.ExecuteScalar();
                    return cnt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        private void UpdateStueckzahlSub(string produktnr, int stueckzahl)
        {
            SqlCommand cmd = new SqlCommand();
            string cmdStr = "";
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(Helper.CnnVal("managementDB")))
                {
                    sqlConn.Open();
                    cmd.Connection = sqlConn;
                    cmdStr = "update produkte set stueckzahl = @stueckzahl" +
                                                    " where produktnr = @produktnr";
                    cmd.CommandText = cmdStr;
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@stueckzahl", --stueckzahl);
                    cmd.Parameters.AddWithValue("@produktnr", produktnr);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateStueckzahlAdd(string produktnr, int stueckzahl)
        {
            SqlCommand cmd = new SqlCommand();
            string cmdStr = "";
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(Helper.CnnVal("managementDB")))
                {
                    sqlConn.Open();
                    cmd.Connection = sqlConn;
                    cmdStr = "update produkte set stueckzahl = @stueckzahl" +
                                                    " where produktnr = @produktnr";
                    cmd.CommandText = cmdStr;
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@stueckzahl", ++stueckzahl);
                    cmd.Parameters.AddWithValue("@produktnr", produktnr);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
