
namespace PABuchungssystemSQL
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvBestellungen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAktualisieren
            // 
            this.btnAktualisieren.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAktualisieren.Location = new System.Drawing.Point(194, 735);
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
            this.lblUeberschriftBestellungen.Location = new System.Drawing.Point(0, 24);
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
            this.dgvBestellungen.Name = "dgvBestellungen";
            this.dgvBestellungen.RowHeadersWidth = 51;
            this.dgvBestellungen.RowTemplate.Height = 24;
            this.dgvBestellungen.Size = new System.Drawing.Size(1295, 600);
            this.dgvBestellungen.TabIndex = 31;
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(11, 735);
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
            this.btnSearch.Location = new System.Drawing.Point(1117, 782);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(160, 37);
            this.btnSearch.TabIndex = 29;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // lblBestellungsnr
            // 
            this.lblBestellungsnr.AutoSize = true;
            this.lblBestellungsnr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBestellungsnr.Location = new System.Drawing.Point(772, 738);
            this.lblBestellungsnr.Name = "lblBestellungsnr";
            this.lblBestellungsnr.Size = new System.Drawing.Size(120, 20);
            this.lblBestellungsnr.TabIndex = 28;
            this.lblBestellungsnr.Text = "BestellungsNr:";
            // 
            // txtBestellungsnr
            // 
            this.txtBestellungsnr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBestellungsnr.Location = new System.Drawing.Point(938, 735);
            this.txtBestellungsnr.Name = "txtBestellungsnr";
            this.txtBestellungsnr.Size = new System.Drawing.Size(339, 26);
            this.txtBestellungsnr.TabIndex = 27;
            // 
            // frmBestellungen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 954);
            this.Controls.Add(this.btnAktualisieren);
            this.Controls.Add(this.btnLöschen);
            this.Controls.Add(this.lblUeberschriftBestellungen);
            this.Controls.Add(this.dgvBestellungen);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblBestellungsnr);
            this.Controls.Add(this.txtBestellungsnr);
            this.Name = "frmBestellungen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bestellungen";
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
    }
}