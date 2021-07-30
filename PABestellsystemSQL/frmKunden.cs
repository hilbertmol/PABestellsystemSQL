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
    public partial class frmKunden : Form
    {
        public frmKunden()
        {
            InitializeComponent();
            UpdateBindingDSource();
            chkbKundennr.Checked = true;
        }

        private DataTable dt = null;
        private DataView dv = null;
        private DataRowView drv = null;

        private void UpdateBindingDSource()
        {
            string tableName = "kunden";
            dt = DataAccess.GetAllManagementDB(tableName);
            dgvKunden.DataSource = dt;
            dv = new DataView(dt);
            dgvKunden.AutoResizeColumns();
            dgvKunden.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sqlDa = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            string cmdStr = "";

            try
            {
                using (SqlConnection sqlConn = new SqlConnection(Helper.CnnVal("managementDB")))
                {
                    sqlConn.Open();

                    if (chkbKundennr.Checked)
                    {
                        cmdStr = "select * from kunden where kundennr = @kundennr";
                        cmd = new SqlCommand(cmdStr, sqlConn);
                        cmd.Parameters.AddWithValue("@kundennr", txtKundennr.Text);
                    }
                    else if (chkbNachname.Checked)
                    {
                        cmdStr = "select * from kunden where nachname like @nachname";
                        cmd = new SqlCommand(cmdStr, sqlConn);
                        cmd.Parameters.AddWithValue("@nachname", txtNachname.Text + "%");
                    }
                    else
                    {
                        cmdStr = "select * from kunden";
                        cmd = new SqlCommand(cmdStr, sqlConn);
                    }
                    sqlDa.SelectCommand = cmd;
                    dt = new DataTable();
                    sqlDa.Fill(dt);
                    dgvKunden.DataSource = dt;
                    dgvKunden.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateBindingDSource();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            drv = dv.AddNew();
            frmKundeBearbeiten frmB = new frmKundeBearbeiten();
            frmB.EditKunde(drv);
            frmB.Dispose();
            UpdateBindingDSource();
        }

        private void btnAktualisieren_Click(object sender, EventArgs e)
        {
            drv = dv[dgvKunden.CurrentRow.Index];
            frmKundeBearbeiten frmB = new frmKundeBearbeiten();
            frmB.EditKunde(drv);
            frmB.Dispose();
            UpdateBindingDSource();
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

        private void chkbKundennr_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbKundennr.Checked)
            {
                chkbNachname.Checked = false;
            }
        }

        private void chkbNachname_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbNachname.Checked)
            {
                chkbKundennr.Checked = false;
            }
        }

        private void btnZurück_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHauptmenue fH = new frmHauptmenue();
            fH.Show();
        }
    } 
}
