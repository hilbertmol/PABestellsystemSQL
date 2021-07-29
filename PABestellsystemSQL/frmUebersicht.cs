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
    public partial class frmUebersicht : Form
    {
        public frmUebersicht()
        {
            InitializeComponent();
            UpdateBindingDSourceKunden();
            UpdateBindingDSourceBestell();
            UpdateBindingDSourceProd();
            lblAnzKA.Text = AnzahlKunden().ToString();
            lblSummeA.Text = SummeBestell().ToString("c");
            lblAnzahlPrA.Text = AnzahlProdukte().ToString();
            //Combobox mit Kriterien belgen
            cmbGruppieren.Items.Add("kundennr");
            cmbGruppieren.Items.Add("hersteller");
            cmbGruppieren.SelectedItem = cmbGruppieren.Items[0];
            dgvProdukte.Columns["pfad"].Visible = false;
            dgvProdukte.Columns["image"].Visible = false;
        }

        private DataTable dt = null;

        private void UpdateBindingDSourceKunden()
        {
            string tableName = "kunden";
            dt = DataAccess.GetAllManagementDB(tableName);
            dgvKunden.DataSource = dt;
            //Breite von Zellen anpassen
            dgvKunden.AutoResizeColumns();
            dgvKunden.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        private void UpdateBindingDSourceBestell()
        {
            string tableName = "bestellungen";
            dt = DataAccess.GetAllManagementDB(tableName);
            dgvBestellungen.DataSource = dt;
            //Breite von Zellen anpassen
            dgvBestellungen.AutoResizeColumns();
            dgvBestellungen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void UpdateBindingDSourceProd()
        {
            string tableName = "produkte";
            dt = DataAccess.GetAllManagementDB(tableName);
            dgvProdukte.DataSource = dt;
            //Breite von Zellen anpassen
            dgvProdukte.AutoResizeColumns();
            dgvProdukte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private int AnzahlKunden()
        {
            SqlCommand cmd = new SqlCommand();

            try
            {
                using (SqlConnection sqlConn = new SqlConnection(Helper.CnnVal("managementDB")))
                {
                    sqlConn.Open();
                    cmd = new SqlCommand("select count(*) from kunden", sqlConn);               
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

        private decimal SummeBestell()
        {
            SqlCommand cmd = new SqlCommand();
            decimal cnt;
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(Helper.CnnVal("managementDB")))
                {
                    sqlConn.Open();
                    cmd.Connection = sqlConn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "SumAll";
                    cmd.Parameters.Add("@summe", SqlDbType.Decimal);
                    cmd.Parameters["@summe"].Direction = ParameterDirection.Output;
                    cmd.ExecuteNonQuery();
                    cnt = Convert.ToDecimal(cmd.Parameters["@summe"].Value);
                    return cnt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        private int AnzahlProdukte()
        {
            SqlCommand cmd = new SqlCommand();

            try
            {
                using (SqlConnection sqlConn = new SqlConnection(Helper.CnnVal("managementDB")))
                {
                    sqlConn.Open();
                    cmd = new SqlCommand("select count(*) from produkte", sqlConn);
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

        private void frmUebersicht_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sqlDa = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();

            try
            {
                using (SqlConnection sqlConn = new SqlConnection(Helper.CnnVal("managementDB")))
                {
                    sqlConn.Open();
                    cmd = new SqlCommand("ShowAll", sqlConn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    sqlDa.SelectCommand = cmd;
                    dt = new DataTable();
                    sqlDa.Fill(dt);
                    dgvUebersicht.DataSource = dt;
                    dgvUebersicht.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGruppieren_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sqlDa = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();

            try
            {
                using (SqlConnection sqlConn = new SqlConnection(Helper.CnnVal("managementDB")))
                {
                    sqlConn.Open();

                    if (cmbGruppieren.SelectedItem.ToString() == "kundennr")
                    {
                        cmd = new SqlCommand("CalculateGroupKNr", sqlConn);
                    }
                    else if (cmbGruppieren.SelectedItem.ToString() == "hersteller")
                    {
                        cmd = new SqlCommand("CalculateGroupHersteller", sqlConn);
                    }
                    else
                    {

                    }

                    cmd.CommandType = CommandType.StoredProcedure;
                    sqlDa.SelectCommand = cmd;
                    dt = new DataTable();
                    sqlDa.Fill(dt);
                    dgvUebersicht.DataSource = dt;
                    dgvUebersicht.Refresh();
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
    }
}
