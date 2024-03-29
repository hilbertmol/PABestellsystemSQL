﻿using System;
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
    public partial class frmBestellungen : Form
    {
        public frmBestellungen()
        {
            InitializeComponent();
            UpdateBindingDSource();
            chkbBestellungsnr.Checked = true;
            dgvBestellungen.Columns["datum"].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm:ss";
        }

        private DataTable dt = null;
        private DataView dv = null;
        private DataRowView drv = null;

        private void UpdateBindingDSource()
        {
            string tableName = "bestellungen";
            dt = DataAccess.GetAllManagementDB(tableName);
            dgvBestellungen.DataSource = dt;
            dv = new DataView(dt);
            dgvBestellungen.AutoResizeColumns();
            dgvBestellungen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            drv = dv.AddNew();
            frmBestellungBearbeiten frmBB = new frmBestellungBearbeiten();
            frmBB.EditBestellung(drv);
            frmBB.Dispose();
            UpdateBindingDSource();
        }

        private void btnAktualisieren_Click(object sender, EventArgs e)
        {
            drv = dv[dgvBestellungen.CurrentRow.Index];
            frmBestellungBearbeiten frmBB = new frmBestellungBearbeiten();
            frmBB.EditBestellung(drv);
            frmBB.Dispose();
            UpdateBindingDSource();
        }

        private void btnLöschen_Click(object sender, EventArgs e)
        {
            string produktnr = dgvBestellungen.CurrentRow.Cells["produktnr"].Value.ToString();
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(Helper.CnnVal("managementDB")))
                {
                    sqlConn.Open();
                    string sqlCmd = "delete from bestellungen where bestellungsnr = '" + dgvBestellungen.CurrentRow.Cells["bestellungsnr"].Value.ToString() + "'";
                    SqlDataAdapter sqlDa = new SqlDataAdapter(sqlCmd, sqlConn);
                    DataTable dt = new DataTable();
                    sqlDa.Fill(dt);
                }
                UpdateStueckzahl(produktnr, GetStueckzahl(produktnr));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            UpdateBindingDSource();
        }

        private void frmBestellungen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void chkbBestellungsnr_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbBestellungsnr.Checked)
            {
                chkbDatum.Checked = false;
            }
        }

        private void chkbDatum_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbDatum.Checked)
            {
                chkbBestellungsnr.Checked = false;
            }
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

                    if (chkbBestellungsnr.Checked)
                    {
                        cmdStr = "select * from bestellungen where bestellungsnr = @bestellungsnr";
                        cmd = new SqlCommand(cmdStr, sqlConn);
                        cmd.Parameters.AddWithValue("@bestellungsnr", txtBestellungsnr.Text);
                    }
                    else if (chkbDatum.Checked)
                    {
                        cmdStr = "select * from bestellungen where datum between @datumstart and @datumend";
                        cmd = new SqlCommand(cmdStr, sqlConn);
                        cmd.Parameters.AddWithValue("@datumstart", dtpVon.Value.ToString("d")); //d: kurzes Datumsformat
                        cmd.Parameters.AddWithValue("@datumend", dtpBis.Value.ToString("d")); //d: kurzes Datumsformat
                    }
                    else
                    {
                        cmdStr = "select * from bestellungen";
                        cmd = new SqlCommand(cmdStr, sqlConn);
                    }
                    sqlDa.SelectCommand = cmd;
                    dt = new DataTable();
                    sqlDa.Fill(dt);
                    dgvBestellungen.DataSource = dt;
                    dgvBestellungen.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnZurück_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHauptmenue fH = new frmHauptmenue();
            fH.Show();
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

        private void UpdateStueckzahl(string produktnr, int stueckzahl)
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
