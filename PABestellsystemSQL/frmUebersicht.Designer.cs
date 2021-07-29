
namespace PABestellsystemSQL
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
            this.btnZurück = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKunden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBestellungen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdukte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUebersicht)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKunden
            // 
            this.dgvKunden.AllowUserToAddRows = false;
            this.dgvKunden.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKunden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKunden.Location = new System.Drawing.Point(27, 80);
            this.dgvKunden.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvKunden.Name = "dgvKunden";
            this.dgvKunden.RowHeadersWidth = 51;
            this.dgvKunden.RowTemplate.Height = 24;
            this.dgvKunden.Size = new System.Drawing.Size(1263, 208);
            this.dgvKunden.TabIndex = 24;
            // 
            // dgvBestellungen
            // 
            this.dgvBestellungen.AllowUserToAddRows = false;
            this.dgvBestellungen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBestellungen.Location = new System.Drawing.Point(27, 320);
            this.dgvBestellungen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvBestellungen.Name = "dgvBestellungen";
            this.dgvBestellungen.RowHeadersWidth = 51;
            this.dgvBestellungen.RowTemplate.Height = 24;
            this.dgvBestellungen.Size = new System.Drawing.Size(600, 185);
            this.dgvBestellungen.TabIndex = 32;
            // 
            // dgvProdukte
            // 
            this.dgvProdukte.AllowUserToAddRows = false;
            this.dgvProdukte.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProdukte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdukte.Location = new System.Drawing.Point(663, 320);
            this.dgvProdukte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProdukte.Name = "dgvProdukte";
            this.dgvProdukte.RowHeadersWidth = 51;
            this.dgvProdukte.RowTemplate.Height = 24;
            this.dgvProdukte.Size = new System.Drawing.Size(627, 185);
            this.dgvProdukte.TabIndex = 40;
            // 
            // dgvUebersicht
            // 
            this.dgvUebersicht.AllowUserToAddRows = false;
            this.dgvUebersicht.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUebersicht.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUebersicht.Location = new System.Drawing.Point(27, 539);
            this.dgvUebersicht.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvUebersicht.Name = "dgvUebersicht";
            this.dgvUebersicht.RowHeadersWidth = 51;
            this.dgvUebersicht.RowTemplate.Height = 24;
            this.dgvUebersicht.Size = new System.Drawing.Size(1263, 240);
            this.dgvUebersicht.TabIndex = 41;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(1129, 801);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(160, 37);
            this.btnSearch.TabIndex = 42;
            this.btnSearch.Text = "Anzeigen";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblUeberschriftProdukte
            // 
            this.lblUeberschriftProdukte.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUeberschriftProdukte.BackColor = System.Drawing.Color.SteelBlue;
            this.lblUeberschriftProdukte.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUeberschriftProdukte.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUeberschriftProdukte.Location = new System.Drawing.Point(1, 11);
            this.lblUeberschriftProdukte.Name = "lblUeberschriftProdukte";
            this.lblUeberschriftProdukte.Size = new System.Drawing.Size(1317, 49);
            this.lblUeberschriftProdukte.TabIndex = 43;
            this.lblUeberschriftProdukte.Text = "Übersicht";
            this.lblUeberschriftProdukte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAnzK
            // 
            this.lblAnzK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAnzK.AutoSize = true;
            this.lblAnzK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnzK.Location = new System.Drawing.Point(23, 807);
            this.lblAnzK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnzK.Name = "lblAnzK";
            this.lblAnzK.Size = new System.Drawing.Size(126, 20);
            this.lblAnzK.TabIndex = 44;
            this.lblAnzK.Text = "Anzahl Kunden:";
            // 
            // lblAnzKA
            // 
            this.lblAnzKA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAnzKA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAnzKA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnzKA.Location = new System.Drawing.Point(199, 801);
            this.lblAnzKA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnzKA.Name = "lblAnzKA";
            this.lblAnzKA.Size = new System.Drawing.Size(143, 33);
            this.lblAnzKA.TabIndex = 45;
            this.lblAnzKA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSummeA
            // 
            this.lblSummeA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSummeA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSummeA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummeA.Location = new System.Drawing.Point(199, 855);
            this.lblSummeA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSummeA.Name = "lblSummeA";
            this.lblSummeA.Size = new System.Drawing.Size(143, 33);
            this.lblSummeA.TabIndex = 47;
            this.lblSummeA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSumme
            // 
            this.lblSumme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSumme.AutoSize = true;
            this.lblSumme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumme.Location = new System.Drawing.Point(23, 862);
            this.lblSumme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSumme.Name = "lblSumme";
            this.lblSumme.Size = new System.Drawing.Size(71, 20);
            this.lblSumme.TabIndex = 46;
            this.lblSumme.Text = "Summe:";
            // 
            // lblAnzahlPrA
            // 
            this.lblAnzahlPrA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAnzahlPrA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAnzahlPrA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnzahlPrA.Location = new System.Drawing.Point(199, 905);
            this.lblAnzahlPrA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnzahlPrA.Name = "lblAnzahlPrA";
            this.lblAnzahlPrA.Size = new System.Drawing.Size(143, 33);
            this.lblAnzahlPrA.TabIndex = 49;
            this.lblAnzahlPrA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAnzahlPr
            // 
            this.lblAnzahlPr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAnzahlPr.AutoSize = true;
            this.lblAnzahlPr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnzahlPr.Location = new System.Drawing.Point(23, 911);
            this.lblAnzahlPr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnzahlPr.Name = "lblAnzahlPr";
            this.lblAnzahlPr.Size = new System.Drawing.Size(136, 20);
            this.lblAnzahlPr.TabIndex = 48;
            this.lblAnzahlPr.Text = "Anzahl Produkte:";
            // 
            // cmbGruppieren
            // 
            this.cmbGruppieren.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbGruppieren.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGruppieren.FormattingEnabled = true;
            this.cmbGruppieren.Location = new System.Drawing.Point(892, 855);
            this.cmbGruppieren.Margin = new System.Windows.Forms.Padding(4);
            this.cmbGruppieren.Name = "cmbGruppieren";
            this.cmbGruppieren.Size = new System.Drawing.Size(159, 28);
            this.cmbGruppieren.TabIndex = 50;
            // 
            // btnGruppieren
            // 
            this.btnGruppieren.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGruppieren.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGruppieren.Location = new System.Drawing.Point(892, 801);
            this.btnGruppieren.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGruppieren.Name = "btnGruppieren";
            this.btnGruppieren.Size = new System.Drawing.Size(160, 37);
            this.btnGruppieren.TabIndex = 51;
            this.btnGruppieren.Text = "Gruppieren";
            this.btnGruppieren.UseVisualStyleBackColor = true;
            this.btnGruppieren.Click += new System.EventHandler(this.btnGruppieren_Click);
            // 
            // btnZurück
            // 
            this.btnZurück.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZurück.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZurück.Location = new System.Drawing.Point(1129, 901);
            this.btnZurück.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnZurück.Name = "btnZurück";
            this.btnZurück.Size = new System.Drawing.Size(160, 37);
            this.btnZurück.TabIndex = 52;
            this.btnZurück.Text = "Zurück";
            this.btnZurück.UseVisualStyleBackColor = true;
            this.btnZurück.Click += new System.EventHandler(this.btnZurück_Click);
            // 
            // frmUebersicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 954);
            this.Controls.Add(this.btnZurück);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmUebersicht";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bestellsystem";
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
        private System.Windows.Forms.Button btnZurück;
    }
}