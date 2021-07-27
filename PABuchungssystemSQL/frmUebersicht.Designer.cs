
namespace PABuchungssystemSQL
{
    partial class frmUebersicht
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
            this.dgvKunden = new System.Windows.Forms.DataGridView();
            this.dgvBestellungen = new System.Windows.Forms.DataGridView();
            this.dgvProdukte = new System.Windows.Forms.DataGridView();
            this.dgvUebersicht = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblUeberschriftProdukte = new System.Windows.Forms.Label();
            this.lblAnzK = new System.Windows.Forms.Label();
            this.lblAnzKA = new System.Windows.Forms.Label();
            this.lblSummeA = new System.Windows.Forms.Label();
            this.lblSumme = new System.Windows.Forms.Label();
            this.lblAnzahlPrA = new System.Windows.Forms.Label();
            this.lblAnzahlPr = new System.Windows.Forms.Label();
            this.cmbGruppieren = new System.Windows.Forms.ComboBox();
            this.btnGruppieren = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKunden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBestellungen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdukte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUebersicht)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKunden
            // 
            this.dgvKunden.AllowUserToAddRows = false;
            this.dgvKunden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKunden.Location = new System.Drawing.Point(20, 65);
            this.dgvKunden.Margin = new System.Windows.Forms.Padding(2);
            this.dgvKunden.Name = "dgvKunden";
            this.dgvKunden.RowHeadersWidth = 51;
            this.dgvKunden.RowTemplate.Height = 24;
            this.dgvKunden.Size = new System.Drawing.Size(947, 169);
            this.dgvKunden.TabIndex = 24;
            // 
            // dgvBestellungen
            // 
            this.dgvBestellungen.AllowUserToAddRows = false;
            this.dgvBestellungen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBestellungen.Location = new System.Drawing.Point(20, 260);
            this.dgvBestellungen.Margin = new System.Windows.Forms.Padding(2);
            this.dgvBestellungen.Name = "dgvBestellungen";
            this.dgvBestellungen.RowHeadersWidth = 51;
            this.dgvBestellungen.RowTemplate.Height = 24;
            this.dgvBestellungen.Size = new System.Drawing.Size(450, 150);
            this.dgvBestellungen.TabIndex = 32;
            // 
            // dgvProdukte
            // 
            this.dgvProdukte.AllowUserToAddRows = false;
            this.dgvProdukte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdukte.Location = new System.Drawing.Point(497, 260);
            this.dgvProdukte.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProdukte.Name = "dgvProdukte";
            this.dgvProdukte.RowHeadersWidth = 51;
            this.dgvProdukte.RowTemplate.Height = 24;
            this.dgvProdukte.Size = new System.Drawing.Size(470, 150);
            this.dgvProdukte.TabIndex = 40;
            // 
            // dgvUebersicht
            // 
            this.dgvUebersicht.AllowUserToAddRows = false;
            this.dgvUebersicht.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUebersicht.Location = new System.Drawing.Point(20, 438);
            this.dgvUebersicht.Margin = new System.Windows.Forms.Padding(2);
            this.dgvUebersicht.Name = "dgvUebersicht";
            this.dgvUebersicht.RowHeadersWidth = 51;
            this.dgvUebersicht.RowTemplate.Height = 24;
            this.dgvUebersicht.Size = new System.Drawing.Size(947, 195);
            this.dgvUebersicht.TabIndex = 41;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(847, 651);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(120, 30);
            this.btnSearch.TabIndex = 42;
            this.btnSearch.Text = "Anzeigen";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblUeberschriftProdukte
            // 
            this.lblUeberschriftProdukte.BackColor = System.Drawing.Color.SteelBlue;
            this.lblUeberschriftProdukte.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUeberschriftProdukte.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUeberschriftProdukte.Location = new System.Drawing.Point(1, 9);
            this.lblUeberschriftProdukte.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUeberschriftProdukte.Name = "lblUeberschriftProdukte";
            this.lblUeberschriftProdukte.Size = new System.Drawing.Size(988, 40);
            this.lblUeberschriftProdukte.TabIndex = 43;
            this.lblUeberschriftProdukte.Text = "Übersicht";
            this.lblUeberschriftProdukte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAnzK
            // 
            this.lblAnzK.AutoSize = true;
            this.lblAnzK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnzK.Location = new System.Drawing.Point(17, 656);
            this.lblAnzK.Name = "lblAnzK";
            this.lblAnzK.Size = new System.Drawing.Size(108, 17);
            this.lblAnzK.TabIndex = 44;
            this.lblAnzK.Text = "Anzahl Kunden:";
            // 
            // lblAnzKA
            // 
            this.lblAnzKA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAnzKA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnzKA.Location = new System.Drawing.Point(149, 651);
            this.lblAnzKA.Name = "lblAnzKA";
            this.lblAnzKA.Size = new System.Drawing.Size(108, 27);
            this.lblAnzKA.TabIndex = 45;
            this.lblAnzKA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSummeA
            // 
            this.lblSummeA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSummeA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummeA.Location = new System.Drawing.Point(149, 695);
            this.lblSummeA.Name = "lblSummeA";
            this.lblSummeA.Size = new System.Drawing.Size(108, 27);
            this.lblSummeA.TabIndex = 47;
            this.lblSummeA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSumme
            // 
            this.lblSumme.AutoSize = true;
            this.lblSumme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumme.Location = new System.Drawing.Point(17, 700);
            this.lblSumme.Name = "lblSumme";
            this.lblSumme.Size = new System.Drawing.Size(59, 17);
            this.lblSumme.TabIndex = 46;
            this.lblSumme.Text = "Summe:";
            // 
            // lblAnzahlPrA
            // 
            this.lblAnzahlPrA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAnzahlPrA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnzahlPrA.Location = new System.Drawing.Point(149, 735);
            this.lblAnzahlPrA.Name = "lblAnzahlPrA";
            this.lblAnzahlPrA.Size = new System.Drawing.Size(108, 27);
            this.lblAnzahlPrA.TabIndex = 49;
            this.lblAnzahlPrA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAnzahlPr
            // 
            this.lblAnzahlPr.AutoSize = true;
            this.lblAnzahlPr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnzahlPr.Location = new System.Drawing.Point(17, 740);
            this.lblAnzahlPr.Name = "lblAnzahlPr";
            this.lblAnzahlPr.Size = new System.Drawing.Size(116, 17);
            this.lblAnzahlPr.TabIndex = 48;
            this.lblAnzahlPr.Text = "Anzahl Produkte:";
            // 
            // cmbGruppieren
            // 
            this.cmbGruppieren.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGruppieren.FormattingEnabled = true;
            this.cmbGruppieren.Location = new System.Drawing.Point(591, 695);
            this.cmbGruppieren.Name = "cmbGruppieren";
            this.cmbGruppieren.Size = new System.Drawing.Size(120, 24);
            this.cmbGruppieren.TabIndex = 50;
            // 
            // btnGruppieren
            // 
            this.btnGruppieren.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGruppieren.Location = new System.Drawing.Point(591, 651);
            this.btnGruppieren.Margin = new System.Windows.Forms.Padding(2);
            this.btnGruppieren.Name = "btnGruppieren";
            this.btnGruppieren.Size = new System.Drawing.Size(120, 30);
            this.btnGruppieren.TabIndex = 51;
            this.btnGruppieren.Text = "Gruppieren";
            this.btnGruppieren.UseVisualStyleBackColor = true;
            this.btnGruppieren.Click += new System.EventHandler(this.btnGruppieren_Click);
            // 
            // frmUebersicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 775);
            this.Controls.Add(this.btnGruppieren);
            this.Controls.Add(this.cmbGruppieren);
            this.Controls.Add(this.lblAnzahlPrA);
            this.Controls.Add(this.lblAnzahlPr);
            this.Controls.Add(this.lblSummeA);
            this.Controls.Add(this.lblSumme);
            this.Controls.Add(this.lblAnzKA);
            this.Controls.Add(this.lblAnzK);
            this.Controls.Add(this.lblUeberschriftProdukte);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvUebersicht);
            this.Controls.Add(this.dgvProdukte);
            this.Controls.Add(this.dgvBestellungen);
            this.Controls.Add(this.dgvKunden);
            this.Name = "frmUebersicht";
            this.Text = "Übersicht";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmUebersicht_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKunden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBestellungen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdukte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUebersicht)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKunden;
        private System.Windows.Forms.DataGridView dgvBestellungen;
        private System.Windows.Forms.DataGridView dgvProdukte;
        private System.Windows.Forms.DataGridView dgvUebersicht;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblUeberschriftProdukte;
        private System.Windows.Forms.Label lblAnzK;
        private System.Windows.Forms.Label lblAnzKA;
        private System.Windows.Forms.Label lblSummeA;
        private System.Windows.Forms.Label lblSumme;
        private System.Windows.Forms.Label lblAnzahlPrA;
        private System.Windows.Forms.Label lblAnzahlPr;
        private System.Windows.Forms.ComboBox cmbGruppieren;
        private System.Windows.Forms.Button btnGruppieren;
    }
}