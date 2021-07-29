
namespace PABestellsystemSQL
{
    partial class frmKunden
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtKundennr = new System.Windows.Forms.TextBox();
            this.lblKundennr = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.dgvKunden = new System.Windows.Forms.DataGridView();
            this.lblUeberschriftKunden = new System.Windows.Forms.Label();
            this.btnLöschen = new System.Windows.Forms.Button();
            this.btnAktualisieren = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNachname = new System.Windows.Forms.TextBox();
            this.chkbKundennr = new System.Windows.Forms.CheckBox();
            this.chkbNachname = new System.Windows.Forms.CheckBox();
            this.btnZurück = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKunden)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKundennr
            // 
            this.txtKundennr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKundennr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKundennr.Location = new System.Drawing.Point(926, 730);
            this.txtKundennr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKundennr.Name = "txtKundennr";
            this.txtKundennr.Size = new System.Drawing.Size(339, 26);
            this.txtKundennr.TabIndex = 1;
            // 
            // lblKundennr
            // 
            this.lblKundennr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKundennr.AutoSize = true;
            this.lblKundennr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKundennr.Location = new System.Drawing.Point(802, 734);
            this.lblKundennr.Name = "lblKundennr";
            this.lblKundennr.Size = new System.Drawing.Size(88, 20);
            this.lblKundennr.TabIndex = 2;
            this.lblKundennr.Text = "KundenNr:";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(1105, 841);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(160, 37);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(12, 730);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(160, 37);
            this.btnInsert.TabIndex = 10;
            this.btnInsert.Text = "Einfügen";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // dgvKunden
            // 
            this.dgvKunden.AllowUserToAddRows = false;
            this.dgvKunden.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKunden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKunden.Location = new System.Drawing.Point(12, 92);
            this.dgvKunden.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvKunden.Name = "dgvKunden";
            this.dgvKunden.RowHeadersWidth = 51;
            this.dgvKunden.RowTemplate.Height = 24;
            this.dgvKunden.Size = new System.Drawing.Size(1295, 601);
            this.dgvKunden.TabIndex = 23;
            // 
            // lblUeberschriftKunden
            // 
            this.lblUeberschriftKunden.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUeberschriftKunden.BackColor = System.Drawing.Color.SteelBlue;
            this.lblUeberschriftKunden.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUeberschriftKunden.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUeberschriftKunden.Location = new System.Drawing.Point(0, 25);
            this.lblUeberschriftKunden.Name = "lblUeberschriftKunden";
            this.lblUeberschriftKunden.Size = new System.Drawing.Size(1317, 49);
            this.lblUeberschriftKunden.TabIndex = 24;
            this.lblUeberschriftKunden.Text = "Kunden";
            this.lblUeberschriftKunden.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnLöschen
            // 
            this.btnLöschen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLöschen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLöschen.Location = new System.Drawing.Point(380, 730);
            this.btnLöschen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLöschen.Name = "btnLöschen";
            this.btnLöschen.Size = new System.Drawing.Size(160, 37);
            this.btnLöschen.TabIndex = 25;
            this.btnLöschen.Text = "Löschen";
            this.btnLöschen.UseVisualStyleBackColor = true;
            this.btnLöschen.Click += new System.EventHandler(this.btnLöschen_Click);
            // 
            // btnAktualisieren
            // 
            this.btnAktualisieren.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAktualisieren.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAktualisieren.Location = new System.Drawing.Point(195, 730);
            this.btnAktualisieren.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAktualisieren.Name = "btnAktualisieren";
            this.btnAktualisieren.Size = new System.Drawing.Size(160, 37);
            this.btnAktualisieren.TabIndex = 26;
            this.btnAktualisieren.Text = "Aktualisieren";
            this.btnAktualisieren.UseVisualStyleBackColor = true;
            this.btnAktualisieren.Click += new System.EventHandler(this.btnAktualisieren_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(802, 789);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Nachname:";
            // 
            // txtNachname
            // 
            this.txtNachname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNachname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNachname.Location = new System.Drawing.Point(926, 786);
            this.txtNachname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNachname.Name = "txtNachname";
            this.txtNachname.Size = new System.Drawing.Size(339, 26);
            this.txtNachname.TabIndex = 27;
            // 
            // chkbKundennr
            // 
            this.chkbKundennr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkbKundennr.AutoSize = true;
            this.chkbKundennr.Location = new System.Drawing.Point(1273, 737);
            this.chkbKundennr.Margin = new System.Windows.Forms.Padding(4);
            this.chkbKundennr.Name = "chkbKundennr";
            this.chkbKundennr.Size = new System.Drawing.Size(18, 17);
            this.chkbKundennr.TabIndex = 51;
            this.chkbKundennr.UseVisualStyleBackColor = true;
            this.chkbKundennr.CheckedChanged += new System.EventHandler(this.chkbKundennr_CheckedChanged);
            // 
            // chkbNachname
            // 
            this.chkbNachname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkbNachname.AutoSize = true;
            this.chkbNachname.Location = new System.Drawing.Point(1273, 793);
            this.chkbNachname.Margin = new System.Windows.Forms.Padding(4);
            this.chkbNachname.Name = "chkbNachname";
            this.chkbNachname.Size = new System.Drawing.Size(18, 17);
            this.chkbNachname.TabIndex = 52;
            this.chkbNachname.UseVisualStyleBackColor = true;
            this.chkbNachname.CheckedChanged += new System.EventHandler(this.chkbNachname_CheckedChanged);
            // 
            // btnZurück
            // 
            this.btnZurück.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnZurück.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZurück.Location = new System.Drawing.Point(12, 906);
            this.btnZurück.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnZurück.Name = "btnZurück";
            this.btnZurück.Size = new System.Drawing.Size(160, 37);
            this.btnZurück.TabIndex = 53;
            this.btnZurück.Text = "Zurück";
            this.btnZurück.UseVisualStyleBackColor = true;
            this.btnZurück.Click += new System.EventHandler(this.btnZurück_Click);
            // 
            // frmKunden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 954);
            this.Controls.Add(this.btnZurück);
            this.Controls.Add(this.chkbKundennr);
            this.Controls.Add(this.chkbNachname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNachname);
            this.Controls.Add(this.btnAktualisieren);
            this.Controls.Add(this.btnLöschen);
            this.Controls.Add(this.lblUeberschriftKunden);
            this.Controls.Add(this.dgvKunden);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblKundennr);
            this.Controls.Add(this.txtKundennr);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmKunden";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bestellsystem";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKunden)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtKundennr;
        private System.Windows.Forms.Label lblKundennr;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DataGridView dgvKunden;
        private System.Windows.Forms.Label lblUeberschriftKunden;
        private System.Windows.Forms.Button btnLöschen;
        private System.Windows.Forms.Button btnAktualisieren;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNachname;
        private System.Windows.Forms.CheckBox chkbKundennr;
        private System.Windows.Forms.CheckBox chkbNachname;
        private System.Windows.Forms.Button btnZurück;
    }
}

