
namespace PABestellsystemSQL
{
    partial class frmProduktBearbeiten
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
            this.btnAbbrechen = new System.Windows.Forms.Button();
            this.txtStueckzahl = new System.Windows.Forms.TextBox();
            this.lblStueckzahl = new System.Windows.Forms.Label();
            this.txtKategorie = new System.Windows.Forms.TextBox();
            this.lblKategorie = new System.Windows.Forms.Label();
            this.txtHersteller = new System.Windows.Forms.TextBox();
            this.lblHersteller = new System.Windows.Forms.Label();
            this.txtProduktname = new System.Windows.Forms.TextBox();
            this.lblProduktname = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtBeschreibung = new System.Windows.Forms.TextBox();
            this.txtPreis = new System.Windows.Forms.TextBox();
            this.txtProduktnr = new System.Windows.Forms.TextBox();
            this.lblBeschreibung = new System.Windows.Forms.Label();
            this.lblPreis = new System.Windows.Forms.Label();
            this.lblProduktnr = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            this.lblPfad = new System.Windows.Forms.Label();
            this.txtPfad = new System.Windows.Forms.TextBox();
            this.picProdukt = new System.Windows.Forms.PictureBox();
            this.lblProduktbearbeiten = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picProdukt)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAbbrechen
            // 
            this.btnAbbrechen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbbrechen.Location = new System.Drawing.Point(470, 779);
            this.btnAbbrechen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAbbrechen.Name = "btnAbbrechen";
            this.btnAbbrechen.Size = new System.Drawing.Size(160, 37);
            this.btnAbbrechen.TabIndex = 62;
            this.btnAbbrechen.Text = "Abbrechen";
            this.btnAbbrechen.UseVisualStyleBackColor = true;
            this.btnAbbrechen.Click += new System.EventHandler(this.btnAbbrechen_Click);
            // 
            // txtStueckzahl
            // 
            this.txtStueckzahl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStueckzahl.Location = new System.Drawing.Point(209, 407);
            this.txtStueckzahl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStueckzahl.Name = "txtStueckzahl";
            this.txtStueckzahl.Size = new System.Drawing.Size(421, 26);
            this.txtStueckzahl.TabIndex = 57;
            // 
            // lblStueckzahl
            // 
            this.lblStueckzahl.AutoSize = true;
            this.lblStueckzahl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStueckzahl.Location = new System.Drawing.Point(57, 410);
            this.lblStueckzahl.Name = "lblStueckzahl";
            this.lblStueckzahl.Size = new System.Drawing.Size(87, 20);
            this.lblStueckzahl.TabIndex = 56;
            this.lblStueckzahl.Text = "Stückzahl:";
            // 
            // txtKategorie
            // 
            this.txtKategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKategorie.Location = new System.Drawing.Point(209, 356);
            this.txtKategorie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKategorie.Name = "txtKategorie";
            this.txtKategorie.Size = new System.Drawing.Size(421, 26);
            this.txtKategorie.TabIndex = 55;
            // 
            // lblKategorie
            // 
            this.lblKategorie.AutoSize = true;
            this.lblKategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKategorie.Location = new System.Drawing.Point(57, 358);
            this.lblKategorie.Name = "lblKategorie";
            this.lblKategorie.Size = new System.Drawing.Size(85, 20);
            this.lblKategorie.TabIndex = 54;
            this.lblKategorie.Text = "Kategorie:";
            // 
            // txtHersteller
            // 
            this.txtHersteller.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHersteller.Location = new System.Drawing.Point(209, 304);
            this.txtHersteller.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHersteller.Name = "txtHersteller";
            this.txtHersteller.Size = new System.Drawing.Size(421, 26);
            this.txtHersteller.TabIndex = 53;
            // 
            // lblHersteller
            // 
            this.lblHersteller.AutoSize = true;
            this.lblHersteller.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHersteller.Location = new System.Drawing.Point(57, 308);
            this.lblHersteller.Name = "lblHersteller";
            this.lblHersteller.Size = new System.Drawing.Size(88, 20);
            this.lblHersteller.TabIndex = 52;
            this.lblHersteller.Text = "Hersteller:";
            // 
            // txtProduktname
            // 
            this.txtProduktname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProduktname.Location = new System.Drawing.Point(209, 156);
            this.txtProduktname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProduktname.Name = "txtProduktname";
            this.txtProduktname.Size = new System.Drawing.Size(421, 26);
            this.txtProduktname.TabIndex = 51;
            // 
            // lblProduktname
            // 
            this.lblProduktname.AutoSize = true;
            this.lblProduktname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduktname.Location = new System.Drawing.Point(57, 159);
            this.lblProduktname.Name = "lblProduktname";
            this.lblProduktname.Size = new System.Drawing.Size(112, 20);
            this.lblProduktname.TabIndex = 50;
            this.lblProduktname.Text = "Produktname:";
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(209, 779);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(160, 37);
            this.btnOK.TabIndex = 49;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtBeschreibung
            // 
            this.txtBeschreibung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBeschreibung.Location = new System.Drawing.Point(209, 253);
            this.txtBeschreibung.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBeschreibung.Name = "txtBeschreibung";
            this.txtBeschreibung.Size = new System.Drawing.Size(421, 26);
            this.txtBeschreibung.TabIndex = 48;
            // 
            // txtPreis
            // 
            this.txtPreis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreis.Location = new System.Drawing.Point(209, 205);
            this.txtPreis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPreis.Name = "txtPreis";
            this.txtPreis.Size = new System.Drawing.Size(421, 26);
            this.txtPreis.TabIndex = 47;
            // 
            // txtProduktnr
            // 
            this.txtProduktnr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProduktnr.Location = new System.Drawing.Point(209, 103);
            this.txtProduktnr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProduktnr.Name = "txtProduktnr";
            this.txtProduktnr.Size = new System.Drawing.Size(421, 26);
            this.txtProduktnr.TabIndex = 46;
            // 
            // lblBeschreibung
            // 
            this.lblBeschreibung.AutoSize = true;
            this.lblBeschreibung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeschreibung.Location = new System.Drawing.Point(57, 256);
            this.lblBeschreibung.Name = "lblBeschreibung";
            this.lblBeschreibung.Size = new System.Drawing.Size(117, 20);
            this.lblBeschreibung.TabIndex = 45;
            this.lblBeschreibung.Text = "Beschreibung:";
            // 
            // lblPreis
            // 
            this.lblPreis.AutoSize = true;
            this.lblPreis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreis.Location = new System.Drawing.Point(57, 209);
            this.lblPreis.Name = "lblPreis";
            this.lblPreis.Size = new System.Drawing.Size(53, 20);
            this.lblPreis.TabIndex = 44;
            this.lblPreis.Text = "Preis:";
            // 
            // lblProduktnr
            // 
            this.lblProduktnr.AutoSize = true;
            this.lblProduktnr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduktnr.Location = new System.Drawing.Point(57, 106);
            this.lblProduktnr.Name = "lblProduktnr";
            this.lblProduktnr.Size = new System.Drawing.Size(89, 20);
            this.lblProduktnr.TabIndex = 43;
            this.lblProduktnr.Text = "ProduktNr:";
            // 
            // btnUpload
            // 
            this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Location = new System.Drawing.Point(628, 647);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(123, 42);
            this.btnUpload.TabIndex = 66;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // lblPfad
            // 
            this.lblPfad.AutoSize = true;
            this.lblPfad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPfad.Location = new System.Drawing.Point(57, 711);
            this.lblPfad.Name = "lblPfad";
            this.lblPfad.Size = new System.Drawing.Size(82, 20);
            this.lblPfad.TabIndex = 65;
            this.lblPfad.Text = "Bild Pfad:";
            // 
            // txtPfad
            // 
            this.txtPfad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPfad.Location = new System.Drawing.Point(209, 708);
            this.txtPfad.Name = "txtPfad";
            this.txtPfad.Size = new System.Drawing.Size(542, 26);
            this.txtPfad.TabIndex = 64;
            // 
            // picProdukt
            // 
            this.picProdukt.BackColor = System.Drawing.Color.Black;
            this.picProdukt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picProdukt.Location = new System.Drawing.Point(209, 459);
            this.picProdukt.Margin = new System.Windows.Forms.Padding(5);
            this.picProdukt.Name = "picProdukt";
            this.picProdukt.Padding = new System.Windows.Forms.Padding(5);
            this.picProdukt.Size = new System.Drawing.Size(230, 230);
            this.picProdukt.TabIndex = 63;
            this.picProdukt.TabStop = false;
            // 
            // lblProduktbearbeiten
            // 
            this.lblProduktbearbeiten.BackColor = System.Drawing.Color.SteelBlue;
            this.lblProduktbearbeiten.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduktbearbeiten.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblProduktbearbeiten.Location = new System.Drawing.Point(1, 21);
            this.lblProduktbearbeiten.Name = "lblProduktbearbeiten";
            this.lblProduktbearbeiten.Size = new System.Drawing.Size(787, 49);
            this.lblProduktbearbeiten.TabIndex = 67;
            this.lblProduktbearbeiten.Text = "Produkt bearbeiten";
            this.lblProduktbearbeiten.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmProduktBearbeiten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 853);
            this.Controls.Add(this.lblProduktbearbeiten);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.lblPfad);
            this.Controls.Add(this.txtPfad);
            this.Controls.Add(this.picProdukt);
            this.Controls.Add(this.btnAbbrechen);
            this.Controls.Add(this.txtStueckzahl);
            this.Controls.Add(this.lblStueckzahl);
            this.Controls.Add(this.txtKategorie);
            this.Controls.Add(this.lblKategorie);
            this.Controls.Add(this.txtHersteller);
            this.Controls.Add(this.lblHersteller);
            this.Controls.Add(this.txtProduktname);
            this.Controls.Add(this.lblProduktname);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtBeschreibung);
            this.Controls.Add(this.txtPreis);
            this.Controls.Add(this.txtProduktnr);
            this.Controls.Add(this.lblBeschreibung);
            this.Controls.Add(this.lblPreis);
            this.Controls.Add(this.lblProduktnr);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmProduktBearbeiten";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bestellsystem";
            ((System.ComponentModel.ISupportInitialize)(this.picProdukt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAbbrechen;
        private System.Windows.Forms.TextBox txtStueckzahl;
        private System.Windows.Forms.Label lblStueckzahl;
        private System.Windows.Forms.TextBox txtKategorie;
        private System.Windows.Forms.Label lblKategorie;
        private System.Windows.Forms.TextBox txtHersteller;
        private System.Windows.Forms.Label lblHersteller;
        private System.Windows.Forms.TextBox txtProduktname;
        private System.Windows.Forms.Label lblProduktname;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtBeschreibung;
        private System.Windows.Forms.TextBox txtPreis;
        private System.Windows.Forms.TextBox txtProduktnr;
        private System.Windows.Forms.Label lblBeschreibung;
        private System.Windows.Forms.Label lblPreis;
        private System.Windows.Forms.Label lblProduktnr;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label lblPfad;
        private System.Windows.Forms.TextBox txtPfad;
        private System.Windows.Forms.PictureBox picProdukt;
        private System.Windows.Forms.Label lblProduktbearbeiten;
    }
}