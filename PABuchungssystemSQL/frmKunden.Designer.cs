
namespace PABuchungssystemSQL
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKunden)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKundennr
            // 
            this.txtKundennr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKundennr.Location = new System.Drawing.Point(939, 730);
            this.txtKundennr.Name = "txtKundennr";
            this.txtKundennr.Size = new System.Drawing.Size(339, 26);
            this.txtKundennr.TabIndex = 1;
            // 
            // lblKundennr
            // 
            this.lblKundennr.AutoSize = true;
            this.lblKundennr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKundennr.Location = new System.Drawing.Point(815, 733);
            this.lblKundennr.Name = "lblKundennr";
            this.lblKundennr.Size = new System.Drawing.Size(110, 25);
            this.lblKundennr.TabIndex = 2;
            this.lblKundennr.Text = "KundenNr:";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(1118, 838);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(160, 37);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(12, 730);
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
            this.dgvKunden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKunden.Location = new System.Drawing.Point(12, 92);
            this.dgvKunden.Name = "dgvKunden";
            this.dgvKunden.RowHeadersWidth = 51;
            this.dgvKunden.RowTemplate.Height = 24;
            this.dgvKunden.Size = new System.Drawing.Size(1295, 600);
            this.dgvKunden.TabIndex = 23;
            // 
            // lblUeberschriftKunden
            // 
            this.lblUeberschriftKunden.BackColor = System.Drawing.Color.SteelBlue;
            this.lblUeberschriftKunden.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUeberschriftKunden.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUeberschriftKunden.Location = new System.Drawing.Point(0, 24);
            this.lblUeberschriftKunden.Name = "lblUeberschriftKunden";
            this.lblUeberschriftKunden.Size = new System.Drawing.Size(1317, 49);
            this.lblUeberschriftKunden.TabIndex = 24;
            this.lblUeberschriftKunden.Text = "Kunden";
            this.lblUeberschriftKunden.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnLöschen
            // 
            this.btnLöschen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLöschen.Location = new System.Drawing.Point(380, 730);
            this.btnLöschen.Name = "btnLöschen";
            this.btnLöschen.Size = new System.Drawing.Size(160, 37);
            this.btnLöschen.TabIndex = 25;
            this.btnLöschen.Text = "Löschen";
            this.btnLöschen.UseVisualStyleBackColor = true;
            this.btnLöschen.Click += new System.EventHandler(this.btnLöschen_Click);
            // 
            // btnAktualisieren
            // 
            this.btnAktualisieren.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAktualisieren.Location = new System.Drawing.Point(195, 730);
            this.btnAktualisieren.Name = "btnAktualisieren";
            this.btnAktualisieren.Size = new System.Drawing.Size(160, 37);
            this.btnAktualisieren.TabIndex = 26;
            this.btnAktualisieren.Text = "Aktualisieren";
            this.btnAktualisieren.UseVisualStyleBackColor = true;
            this.btnAktualisieren.Click += new System.EventHandler(this.btnAktualisieren_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(815, 789);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Nachname:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(939, 786);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(339, 26);
            this.textBox1.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 954);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnAktualisieren);
            this.Controls.Add(this.btnLöschen);
            this.Controls.Add(this.lblUeberschriftKunden);
            this.Controls.Add(this.dgvKunden);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblKundennr);
            this.Controls.Add(this.txtKundennr);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kunden";
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
        private System.Windows.Forms.TextBox textBox1;
    }
}

