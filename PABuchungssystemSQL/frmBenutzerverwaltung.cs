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
    public partial class frmBenutzerverwaltung : Form
    {
        public frmBenutzerverwaltung()
        {
            InitializeComponent();
            UpdateBindingDSource();
            dgvBenutzer.MultiSelect = false;
        }

        private DataTable dt = null;
        private DataView dv = null;
        private DataRowView drv = null;

        private void UpdateBindingDSource()
        {
            string tableName = "userdata";
            dt = DataAccess.GetAllLoginDB(tableName);
            dgvBenutzer.DataSource = dt;
            dv = new DataView(dt);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            drv = dv.AddNew();
            frmBenutzerBearbeiten frmBB = new frmBenutzerBearbeiten();
            frmBB.EditBenutzer(drv);
            frmBB.Dispose();
            UpdateBindingDSource();
        }

        private void btnAktualisieren_Click(object sender, EventArgs e)
        {
            drv = dv[dgvBenutzer.CurrentRow.Index];
            frmBenutzerBearbeiten frmBB = new frmBenutzerBearbeiten();
            frmBB.EditBenutzer(drv);
            frmBB.Dispose();
            UpdateBindingDSource();
        }

        private void btnLöschen_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(Helper.CnnVal("loginDB")))
                {
                    sqlConn.Open();
                    string sqlCmd = "delete from userdata where login = '" + dgvBenutzer.CurrentRow.Cells["login"].Value.ToString() + "'";
                    SqlDataAdapter sqlDa = new SqlDataAdapter(sqlCmd, sqlConn);
                    DataTable dt = new DataTable();
                    sqlDa.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            UpdateBindingDSource();
            dgvBenutzer.Refresh();
        }

        private void frmBestellungen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dgvBenutzer_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.Value != null)
            {
                e.Value = new String('*', e.Value.ToString().Length);
            }
        }

        private void btnZurueck_Click(object sender, EventArgs e)
        {
            int currentRow = dgvBenutzer.CurrentCell.RowIndex;
            if (currentRow > 0)
            {
                dgvBenutzer.CurrentCell = dgvBenutzer.Rows[--currentRow].Cells[0];
                dgvBenutzer_SelectionChanged(sender, e);
            }
        }

        private void btnVor_Click(object sender, EventArgs e)
        {
            int currentRow = dgvBenutzer.CurrentCell.RowIndex;
            if (currentRow < dgvBenutzer.Rows.Count - 1)
            {
                dgvBenutzer.CurrentCell = dgvBenutzer.Rows[++currentRow].Cells[0];
                dgvBenutzer_SelectionChanged(sender, e);
            }
        }

        private void dgvBenutzer_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBenutzer.Rows.Count != 0)
            {
                int currentRow = dgvBenutzer.CurrentCell.RowIndex;
                lblLoginA.Text = dgvBenutzer.Rows[currentRow].Cells["login"].Value.ToString();
                lblVornameA.Text = dgvBenutzer.Rows[currentRow].Cells["vorname"].Value.ToString();
                lblNachnameA.Text = dgvBenutzer.Rows[currentRow].Cells["nachname"].Value.ToString();
                lblEmailA.Text = dgvBenutzer.Rows[currentRow].Cells["email"].Value.ToString();
                lblTypA.Text = dgvBenutzer.Rows[currentRow].Cells["typ"].Value.ToString();
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
