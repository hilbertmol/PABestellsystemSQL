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
    public partial class frmBestellungen : Form
    {
        public frmBestellungen()
        {
            InitializeComponent();
            UpdateBindingDSource();
            dgvBestellungen.Columns["datum"].DefaultCellStyle.Format = "dd:MM:yyyy HH:mm:ss";
        }

        private DataTable dt = null;
        private DataView dv = null;
        private DataRowView drv = null;

        private void UpdateBindingDSource()
        {
            string tableName = "bestellungen";
            dt = DataAccess.GetAll(tableName);
            dgvBestellungen.DataSource = dt;
            dv = new DataView(dt);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            UpdateBindingDSource();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateBindingDSource();
        }

        private void btnAktualisieren_Click(object sender, EventArgs e)
        {
            drv = dv[dgvBestellungen.CurrentRow.Index];
            frmBestellungBearbeiten frmBB = new frmBestellungBearbeiten();
            frmBB.EditKunde(drv);
            frmBB.Dispose();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            drv = dv.AddNew();
            frmBestellungBearbeiten frmBB = new frmBestellungBearbeiten();
            frmBB.EditKunde(drv);
            frmBB.Dispose();
            dgvBestellungen.Refresh();
        }

        private void btnLöschen_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(Helper.CnnVal("managementDB")))
                {
                    sqlConn.Open();
                    string sqlCmd = "delete from bestellungen where bestellungsnr = '" + dgvBestellungen.CurrentRow.Cells["bestellungsnr"].Value.ToString() + "'";
                    SqlDataAdapter sqlDa = new SqlDataAdapter(sqlCmd, sqlConn);
                    DataTable dt = new DataTable();
                    sqlDa.Fill(dt);
                    sqlConn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            UpdateBindingDSource();
            dgvBestellungen.Refresh();
        }

        private void frmBestellungen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
