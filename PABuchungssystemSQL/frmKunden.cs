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
    public partial class frmKunden : Form
    {
        public frmKunden()
        {
            InitializeComponent();
            UpdateBindingDSource();
        }

        private DataTable dt = null;
        private DataView dv = null;
        private DataRowView drv = null;

        private void UpdateBindingDSource()
        {
            string tableName = "kunden";
            dt = DataAccess.GetAll(tableName);
            dgvKunden.DataSource = dt;
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
            drv = dv[dgvKunden.CurrentRow.Index];
            frmKundeBearbeiten frmB = new frmKundeBearbeiten();
            frmB.EditKunde(drv);
            frmB.Dispose();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            drv = dv.AddNew();
            frmKundeBearbeiten frmB = new frmKundeBearbeiten();
            frmB.EditKunde(drv);
            frmB.Dispose();
            dgvKunden.Refresh();
        }

        private void btnLöschen_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(Helper.CnnVal("managementDB")))
                {
                    sqlConn.Open();
                    string sqlCmd = "delete from kunden where kundennr = '" + dgvKunden.CurrentRow.Cells["kundennr"].Value.ToString() + "'";
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
            dgvKunden.Refresh();
        }
    } 
}
