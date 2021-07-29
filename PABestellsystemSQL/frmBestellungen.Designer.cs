
namespace PABestellsystemSQL
{
    partial class frmBestellungen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAktualisieren = new System.Windows.Forms.Button();
            this.btnLöschen = new System.Windows.Forms.Button();
            this.lblUeberschriftBestellungen = new System.Windows.Forms.Label();
            this.dgvBestellungen = new System.Windows.Forms.DataGridView();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblBestellungsnr = new System.Windows.Forms.Label();
            this.txtBestellungsnr = new System.Windows.Forms.TextBox();
            this.lblDatum = new System.Windows.Forms.Label();
            this.dtpBis = new System.Windows.Forms.DateTimePicker();
            this.dtpVon = new System.Windows.Forms.DateTimePicker();
            this.lblVon = new System.Windows.Forms.Label();
            this.lblBis = new System.Windows.Forms.Label();
            this.chkbBestellungsnr = new System.Windows.Forms.CheckBox();
            this.chkbDatum = new System.Windows.Forms.CheckBox();
            this.btnZurück = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBestellungen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAktualisieren
            // 
            this.btnAktualisieren.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAktualisieren.Location = new System.Drawing.Point(195, 735);
            this.btnAktualisieren.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAktualisieren.Name = "btnAktualisieren";
            this.btnAktualisieren.Size = new System.Drawing.Size(160, 37);
            this.btnAktualisieren.TabIndex = 34;
            this.btnAktualisieren.Text = "Aktualisieren";
            this.btnAktualisieren.UseVisualStyleBackColor = true;
            this.btnAktualisieren.Click += new System.EventHandler(this.btnAktualisieren_Click);
            // 
            // btnLöschen
            // 
            this.btnLöschen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLöschen.Location = new System.Drawing.Point(379, 735);
            this.btnLöschen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLöschen.Name = "btnLöschen";
            this.btnLöschen.Size = new System.Drawing.Size(160, 37);
            this.btnLöschen.TabIndex = 33;
            this.btnLöschen.Text = "Löschen";
            this.btnLöschen.UseVisualStyleBackColor = true;
            this.btnLöschen.Click += new System.EventHandler(this.btnLöschen_Click);
            // 
            // lblUeberschriftBestellungen
            // 
            this.lblUeberschriftBestellungen.BackColor = System.Drawing.Color.SteelBlue;
            this.lblUeberschriftBestellungen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUeberschriftBestellungen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUeberschriftBestellungen.Location = new System.Drawing.Point(0, 25);
            this.lblUeberschriftBestellungen.Name = "lblUeberschriftBestellungen";
            this.lblUeberschriftBestellungen.Size = new System.Drawing.Size(1317, 49);
            this.lblUeberschriftBestellungen.TabIndex = 32;
            this.lblUeberschriftBestellungen.Text = "Bestellungen";
            this.lblUeberschriftBestellungen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvBestellungen
            // 
            this.dgvBestellungen.AllowUserToAddRows = false;
            this.dgvBestellungen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBestellungen.Location = new System.Drawing.Point(11, 97);
            this.dgvBestellungen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvBestellungen.Name = "dgvBestellungen";
            this.dgvBestellungen.RowHeadersWidth = 51;
            this.dgvBestellungen.RowTemplate.Height = 24;
            this.dgvBestellungen.Size = new System.Drawing.Size(1295, 601);
            this.dgvBestellungen.TabIndex = 31;
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(11, 735);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(160, 37);
            this.btnInsert.TabIndex = 30;
            this.btnInsert.Text = "Einfügen";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(1083, 876);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(160, 37);
            this.btnSearch.TabIndex = 29;
            this.btnSearch.Text = "Suchen";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblBestellungsnr
            // 
            this.lblBestellungsnr.AutoSize = true;
            this.lblBestellungsnr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBestellungsnr.Location = new System.Drawing.Point(826, 738);
            this.lblBestellungsnr.Name = "lblBestellungsnr";
            this.lblBestellungsnr.Size = new System.Drawing.Size(120, 20);
            this.lblBestellungsnr.TabIndex = 28;
            this.lblBestellungsnr.Text = "BestellungsNr:";
            // 
            // txtBestellungsnr
            // 
            this.txtBestellungsnr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBestellungsnr.Location = new System.Drawing.Point(992, 735);
            this.txtBestellungsnr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBestellungsnr.Name = "txtBestellungsnr";
            this.txtBestellungsnr.Size = new System.Drawing.Size(249, 26);
            this.txtBestellungsnr.TabIndex = 27;
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatum.Location = new System.Drawing.Point(827, 796);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(59, 20);
            this.lblDatum.TabIndex = 35;
            this.lblDatum.Text = "Datum";
            // 
            // dtpBis
            // 
            this.dtpBis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBis.Location = new System.Drawing.Point(992, 826);
            this.dtpBis.Margin = new System.Windows.Forms.Padding(4);
            this.dtpBis.Name = "dtpBis";
            this.dtpBis.Size = new System.Drawing.Size(249, 26);
            this.dtpBis.TabIndex = 64;
            // 
            // dtpVon
            // 
            this.dtpVon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpVon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVon.Location = new System.Drawing.Point(992, 789);
            this.dtpVon.Margin = new System.Windows.Forms.Padding(4);
            this.dtpVon.Name = "dtpVon";
            this.dtpVon.Size = new System.Drawing.Size(249, 26);
            this.dtpVon.TabIndex = 65;
            // 
            // lblVon
            // 
            this.lblVon.AutoSize = true;
            this.lblVon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVon.Location = new System.Drawing.Point(914, 796);
            this.lblVon.Name = "lblVon";
            this.lblVon.Size = new System.Drawing.Size(45, 20);
            this.lblVon.TabIndex = 66;
            this.lblVon.Text = "von: ";
            // 
            // lblBis
            // 
            this.lblBis.AutoSize = true;
            this.lblBis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBis.Location = new System.Drawing.Point(920, 833);
            this.lblBis.Name = "lblBis";
            this.lblBis.Size = new System.Drawing.Size(41, 20);
            this.lblBis.TabIndex = 67;
            this.lblBis.Text = "bis: ";
            // 
            // chkbBestellungsnr
            // 
            this.chkbBestellungsnr.AutoSize = true;
            this.chkbBestellungsnr.Location = new System.Drawing.Point(1262, 742);
            this.chkbBestellungsnr.Margin = new System.Windows.Forms.Padding(4);
            this.chkbBestellungsnr.Name = "chkbBestellungsnr";
            this.chkbBestellungsnr.Size = new System.Drawing.Size(18, 17);
            this.chkbBestellungsnr.TabIndex = 68;
            this.chkbBestellungsnr.UseVisualStyleBackColor = true;
            this.chkbBestellungsnr.CheckedChanged += new System.EventHandler(this.chkbBestellungsnr_CheckedChanged);
            // 
            // chkbDatum
            // 
            this.chkbDatum.AutoSize = true;
            this.chkbDatum.Location = new System.Drawing.Point(1262, 798);
            this.chkbDatum.Margin = new System.Windows.Forms.Padding(4);
            this.chkbDatum.Name = "chkbDatum";
            this.chkbDatum.Size = new System.Drawing.Size(18, 17);
            this.chkbDatum.TabIndex = 70;
            this.chkbDatum.UseVisualStyleBackColor = true;
            this.chkbDatum.CheckedChanged += new System.EventHandler(this.chkbDatum_CheckedChanged);
            // 
            // btnZurück
            // 
            this.btnZurück.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZurück.Location = new System.Drawing.Point(11, 876);
            this.btnZurück.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnZurück.Name = "btnZurück";
            this.btnZurück.Size = new System.Drawing.Size(160, 37);
            this.btnZurück.TabIndex = 71;
            this.btnZurück.Text = "Zurück";
            this.btnZurück.UseVisualStyleBackColor = true;
            this.btnZurück.Click += new System.EventHandler(this.btnZurück_Click);
            // 
            // frmBestellungen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 954);
            this.Controls.Add(this.btnZurück);
            this.Controls.Add(this.chkbBestellungsnr);
            this.Controls.Add(this.chkbDatum);
            this.Controls.Add(this.lblBis);
            this.Controls.Add(this.lblVon);
            this.Controls.Add(this.dtpVon);
            this.Controls.Add(this.dtpBis);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.btnAktualisieren);
            this.Controls.Add(this.btnLöschen);
            this.Controls.Add(this.lblUeberschriftBestellungen);
            this.Controls.Add(this.dgvBestellungen);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblBestellungsnr);
            this.Controls.Add(this.txtBestellungsnr);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmBestellungen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bestellsystem";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBestellungen_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBestellungen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAktualisieren;
        private System.Windows.Forms.Button btnLöschen;
        private System.Windows.Forms.Label lblUeberschriftBestellungen;
        private System.Windows.Forms.DataGridView dgvBestellungen;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblBestellungsnr;
        private System.Windows.Forms.TextBox txtBestellungsnr;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.DateTimePicker dtpBis;
        private System.Windows.Forms.DateTimePicker dtpVon;
        private System.Windows.Forms.Label lblVon;
        private System.Windows.Forms.Label lblBis;
        private System.Windows.Forms.CheckBox chkbBestellungsnr;
        private System.Windows.Forms.CheckBox chkbDatum;
        private System.Windows.Forms.Button btnZurück;
    }
}