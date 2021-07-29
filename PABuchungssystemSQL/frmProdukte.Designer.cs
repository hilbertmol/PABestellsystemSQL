
namespace PABuchungssystemSQL
{
    partial class frmProdukte
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
            this.lblUeberschriftProdukte = new System.Windows.Forms.Label();
            this.dgvProdukte = new System.Windows.Forms.DataGridView();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblProduktnr = new System.Windows.Forms.Label();
            this.txtProduktnr = new System.Windows.Forms.TextBox();
            this.lblProduktname = new System.Windows.Forms.Label();
            this.txtProduktname = new System.Windows.Forms.TextBox();
            this.cmbKategorie = new System.Windows.Forms.ComboBox();
            this.lblKategorie = new System.Windows.Forms.Label();
            this.chkbProduktnr = new System.Windows.Forms.CheckBox();
            this.chkbProduktname = new System.Windows.Forms.CheckBox();
            this.chkbKategorie = new System.Windows.Forms.CheckBox();
            this.btnZurück = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdukte)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAktualisieren
            // 
            this.btnAktualisieren.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAktualisieren.Location = new System.Drawing.Point(195, 735);
            this.btnAktualisieren.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAktualisieren.Name = "btnAktualisieren";
            this.btnAktualisieren.Size = new System.Drawing.Size(160, 37);
            this.btnAktualisieren.TabIndex = 42;
            this.btnAktualisieren.Text = "Aktualisieren";
            this.btnAktualisieren.UseVisualStyleBackColor = true;
            this.btnAktualisieren.Click += new System.EventHandler(this.btnAktualisieren_Click);
            // 
            // btnLöschen
            // 
            this.btnLöschen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLöschen.Location = new System.Drawing.Point(380, 735);
            this.btnLöschen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLöschen.Name = "btnLöschen";
            this.btnLöschen.Size = new System.Drawing.Size(160, 37);
            this.btnLöschen.TabIndex = 41;
            this.btnLöschen.Text = "Löschen";
            this.btnLöschen.UseVisualStyleBackColor = true;
            this.btnLöschen.Click += new System.EventHandler(this.btnLöschen_Click);
            // 
            // lblUeberschriftProdukte
            // 
            this.lblUeberschriftProdukte.BackColor = System.Drawing.Color.SteelBlue;
            this.lblUeberschriftProdukte.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUeberschriftProdukte.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUeberschriftProdukte.Location = new System.Drawing.Point(1, 25);
            this.lblUeberschriftProdukte.Name = "lblUeberschriftProdukte";
            this.lblUeberschriftProdukte.Size = new System.Drawing.Size(1317, 49);
            this.lblUeberschriftProdukte.TabIndex = 40;
            this.lblUeberschriftProdukte.Text = "Produkte";
            this.lblUeberschriftProdukte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvProdukte
            // 
            this.dgvProdukte.AllowUserToAddRows = false;
            this.dgvProdukte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdukte.Location = new System.Drawing.Point(12, 97);
            this.dgvProdukte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProdukte.Name = "dgvProdukte";
            this.dgvProdukte.RowHeadersWidth = 51;
            this.dgvProdukte.RowTemplate.Height = 24;
            this.dgvProdukte.Size = new System.Drawing.Size(1295, 601);
            this.dgvProdukte.TabIndex = 39;
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(12, 735);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(160, 37);
            this.btnInsert.TabIndex = 38;
            this.btnInsert.Text = "Einfügen";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(1100, 884);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(160, 37);
            this.btnSearch.TabIndex = 37;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // lblProduktnr
            // 
            this.lblProduktnr.AutoSize = true;
            this.lblProduktnr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduktnr.Location = new System.Drawing.Point(755, 738);
            this.lblProduktnr.Name = "lblProduktnr";
            this.lblProduktnr.Size = new System.Drawing.Size(89, 20);
            this.lblProduktnr.TabIndex = 36;
            this.lblProduktnr.Text = "ProduktNr:";
            // 
            // txtProduktnr
            // 
            this.txtProduktnr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProduktnr.Location = new System.Drawing.Point(921, 735);
            this.txtProduktnr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProduktnr.Name = "txtProduktnr";
            this.txtProduktnr.Size = new System.Drawing.Size(339, 26);
            this.txtProduktnr.TabIndex = 35;
            // 
            // lblProduktname
            // 
            this.lblProduktname.AutoSize = true;
            this.lblProduktname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduktname.Location = new System.Drawing.Point(755, 786);
            this.lblProduktname.Name = "lblProduktname";
            this.lblProduktname.Size = new System.Drawing.Size(112, 20);
            this.lblProduktname.TabIndex = 44;
            this.lblProduktname.Text = "Produktname:";
            // 
            // txtProduktname
            // 
            this.txtProduktname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProduktname.Location = new System.Drawing.Point(921, 783);
            this.txtProduktname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProduktname.Name = "txtProduktname";
            this.txtProduktname.Size = new System.Drawing.Size(339, 26);
            this.txtProduktname.TabIndex = 43;
            // 
            // cmbKategorie
            // 
            this.cmbKategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKategorie.FormattingEnabled = true;
            this.cmbKategorie.Location = new System.Drawing.Point(921, 828);
            this.cmbKategorie.Margin = new System.Windows.Forms.Padding(4);
            this.cmbKategorie.Name = "cmbKategorie";
            this.cmbKategorie.Size = new System.Drawing.Size(339, 28);
            this.cmbKategorie.TabIndex = 45;
            // 
            // lblKategorie
            // 
            this.lblKategorie.AutoSize = true;
            this.lblKategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKategorie.Location = new System.Drawing.Point(755, 832);
            this.lblKategorie.Name = "lblKategorie";
            this.lblKategorie.Size = new System.Drawing.Size(85, 20);
            this.lblKategorie.TabIndex = 46;
            this.lblKategorie.Text = "Kategorie:";
            // 
            // chkbProduktnr
            // 
            this.chkbProduktnr.AutoSize = true;
            this.chkbProduktnr.Location = new System.Drawing.Point(1269, 742);
            this.chkbProduktnr.Margin = new System.Windows.Forms.Padding(4);
            this.chkbProduktnr.Name = "chkbProduktnr";
            this.chkbProduktnr.Size = new System.Drawing.Size(18, 17);
            this.chkbProduktnr.TabIndex = 49;
            this.chkbProduktnr.UseVisualStyleBackColor = true;
            this.chkbProduktnr.CheckedChanged += new System.EventHandler(this.chkbProduktnr_CheckedChanged);
            // 
            // chkbProduktname
            // 
            this.chkbProduktname.AutoSize = true;
            this.chkbProduktname.Location = new System.Drawing.Point(1269, 790);
            this.chkbProduktname.Margin = new System.Windows.Forms.Padding(4);
            this.chkbProduktname.Name = "chkbProduktname";
            this.chkbProduktname.Size = new System.Drawing.Size(18, 17);
            this.chkbProduktname.TabIndex = 50;
            this.chkbProduktname.UseVisualStyleBackColor = true;
            this.chkbProduktname.CheckedChanged += new System.EventHandler(this.chkbProduktname_CheckedChanged);
            // 
            // chkbKategorie
            // 
            this.chkbKategorie.AutoSize = true;
            this.chkbKategorie.Location = new System.Drawing.Point(1269, 836);
            this.chkbKategorie.Margin = new System.Windows.Forms.Padding(4);
            this.chkbKategorie.Name = "chkbKategorie";
            this.chkbKategorie.Size = new System.Drawing.Size(18, 17);
            this.chkbKategorie.TabIndex = 51;
            this.chkbKategorie.UseVisualStyleBackColor = true;
            this.chkbKategorie.CheckedChanged += new System.EventHandler(this.chkbKategorie_CheckedChanged);
            // 
            // btnZurück
            // 
            this.btnZurück.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZurück.Location = new System.Drawing.Point(12, 903);
            this.btnZurück.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnZurück.Name = "btnZurück";
            this.btnZurück.Size = new System.Drawing.Size(160, 37);
            this.btnZurück.TabIndex = 53;
            this.btnZurück.Text = "Zurück";
            this.btnZurück.UseVisualStyleBackColor = true;
            this.btnZurück.Click += new System.EventHandler(this.btnZurück_Click);
            // 
            // frmProdukte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 954);
            this.Controls.Add(this.btnZurück);
            this.Controls.Add(this.chkbProduktnr);
            this.Controls.Add(this.chkbProduktname);
            this.Controls.Add(this.chkbKategorie);
            this.Controls.Add(this.lblKategorie);
            this.Controls.Add(this.cmbKategorie);
            this.Controls.Add(this.lblProduktname);
            this.Controls.Add(this.txtProduktname);
            this.Controls.Add(this.btnAktualisieren);
            this.Controls.Add(this.btnLöschen);
            this.Controls.Add(this.lblUeberschriftProdukte);
            this.Controls.Add(this.dgvProdukte);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblProduktnr);
            this.Controls.Add(this.txtProduktnr);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmProdukte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bestellsystem";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmProdukte_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdukte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAktualisieren;
        private System.Windows.Forms.Button btnLöschen;
        private System.Windows.Forms.Label lblUeberschriftProdukte;
        private System.Windows.Forms.DataGridView dgvProdukte;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblProduktnr;
        private System.Windows.Forms.TextBox txtProduktnr;
        private System.Windows.Forms.Label lblProduktname;
        private System.Windows.Forms.TextBox txtProduktname;
        private System.Windows.Forms.ComboBox cmbKategorie;
        private System.Windows.Forms.Label lblKategorie;
        private System.Windows.Forms.CheckBox chkbProduktnr;
        private System.Windows.Forms.CheckBox chkbProduktname;
        private System.Windows.Forms.CheckBox chkbKategorie;
        private System.Windows.Forms.Button btnZurück;
    }
}