
namespace PABuchungssystemSQL
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
            this.SuspendLayout();
            // 
            // btnAbbrechen
            // 
            this.btnAbbrechen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbbrechen.Location = new System.Drawing.Point(371, 421);
            this.btnAbbrechen.Margin = new System.Windows.Forms.Padding(2);
            this.btnAbbrechen.Name = "btnAbbrechen";
            this.btnAbbrechen.Size = new System.Drawing.Size(120, 30);
            this.btnAbbrechen.TabIndex = 62;
            this.btnAbbrechen.Text = "Abbrechen";
            this.btnAbbrechen.UseVisualStyleBackColor = true;
            this.btnAbbrechen.Click += new System.EventHandler(this.btnAbbrechen_Click);
            // 
            // txtStueckzahl
            // 
            this.txtStueckzahl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStueckzahl.Location = new System.Drawing.Point(174, 378);
            this.txtStueckzahl.Margin = new System.Windows.Forms.Padding(2);
            this.txtStueckzahl.Name = "txtStueckzahl";
            this.txtStueckzahl.Size = new System.Drawing.Size(317, 23);
            this.txtStueckzahl.TabIndex = 57;
            // 
            // lblStueckzahl
            // 
            this.lblStueckzahl.AutoSize = true;
            this.lblStueckzahl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStueckzahl.Location = new System.Drawing.Point(60, 380);
            this.lblStueckzahl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStueckzahl.Name = "lblStueckzahl";
            this.lblStueckzahl.Size = new System.Drawing.Size(73, 17);
            this.lblStueckzahl.TabIndex = 56;
            this.lblStueckzahl.Text = "Stückzahl:";
            // 
            // txtKategorie
            // 
            this.txtKategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKategorie.Location = new System.Drawing.Point(174, 336);
            this.txtKategorie.Margin = new System.Windows.Forms.Padding(2);
            this.txtKategorie.Name = "txtKategorie";
            this.txtKategorie.Size = new System.Drawing.Size(317, 23);
            this.txtKategorie.TabIndex = 55;
            // 
            // lblKategorie
            // 
            this.lblKategorie.AutoSize = true;
            this.lblKategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKategorie.Location = new System.Drawing.Point(60, 338);
            this.lblKategorie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKategorie.Name = "lblKategorie";
            this.lblKategorie.Size = new System.Drawing.Size(73, 17);
            this.lblKategorie.TabIndex = 54;
            this.lblKategorie.Text = "Kategorie:";
            // 
            // txtHersteller
            // 
            this.txtHersteller.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHersteller.Location = new System.Drawing.Point(174, 294);
            this.txtHersteller.Margin = new System.Windows.Forms.Padding(2);
            this.txtHersteller.Name = "txtHersteller";
            this.txtHersteller.Size = new System.Drawing.Size(317, 23);
            this.txtHersteller.TabIndex = 53;
            // 
            // lblHersteller
            // 
            this.lblHersteller.AutoSize = true;
            this.lblHersteller.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHersteller.Location = new System.Drawing.Point(60, 297);
            this.lblHersteller.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHersteller.Name = "lblHersteller";
            this.lblHersteller.Size = new System.Drawing.Size(73, 17);
            this.lblHersteller.TabIndex = 52;
            this.lblHersteller.Text = "Hersteller:";
            // 
            // txtProduktname
            // 
            this.txtProduktname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProduktname.Location = new System.Drawing.Point(174, 174);
            this.txtProduktname.Margin = new System.Windows.Forms.Padding(2);
            this.txtProduktname.Name = "txtProduktname";
            this.txtProduktname.Size = new System.Drawing.Size(317, 23);
            this.txtProduktname.TabIndex = 51;
            // 
            // lblProduktname
            // 
            this.lblProduktname.AutoSize = true;
            this.lblProduktname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduktname.Location = new System.Drawing.Point(60, 176);
            this.lblProduktname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProduktname.Name = "lblProduktname";
            this.lblProduktname.Size = new System.Drawing.Size(96, 17);
            this.lblProduktname.TabIndex = 50;
            this.lblProduktname.Text = "Produktname:";
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(174, 421);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(120, 30);
            this.btnOK.TabIndex = 49;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtBeschreibung
            // 
            this.txtBeschreibung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBeschreibung.Location = new System.Drawing.Point(174, 253);
            this.txtBeschreibung.Margin = new System.Windows.Forms.Padding(2);
            this.txtBeschreibung.Name = "txtBeschreibung";
            this.txtBeschreibung.Size = new System.Drawing.Size(317, 23);
            this.txtBeschreibung.TabIndex = 48;
            // 
            // txtPreis
            // 
            this.txtPreis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreis.Location = new System.Drawing.Point(174, 214);
            this.txtPreis.Margin = new System.Windows.Forms.Padding(2);
            this.txtPreis.Name = "txtPreis";
            this.txtPreis.Size = new System.Drawing.Size(317, 23);
            this.txtPreis.TabIndex = 47;
            // 
            // txtProduktnr
            // 
            this.txtProduktnr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProduktnr.Location = new System.Drawing.Point(174, 131);
            this.txtProduktnr.Margin = new System.Windows.Forms.Padding(2);
            this.txtProduktnr.Name = "txtProduktnr";
            this.txtProduktnr.Size = new System.Drawing.Size(317, 23);
            this.txtProduktnr.TabIndex = 46;
            // 
            // lblBeschreibung
            // 
            this.lblBeschreibung.AutoSize = true;
            this.lblBeschreibung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeschreibung.Location = new System.Drawing.Point(60, 255);
            this.lblBeschreibung.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBeschreibung.Name = "lblBeschreibung";
            this.lblBeschreibung.Size = new System.Drawing.Size(99, 17);
            this.lblBeschreibung.TabIndex = 45;
            this.lblBeschreibung.Text = "Beschreibung:";
            // 
            // lblPreis
            // 
            this.lblPreis.AutoSize = true;
            this.lblPreis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreis.Location = new System.Drawing.Point(60, 217);
            this.lblPreis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPreis.Name = "lblPreis";
            this.lblPreis.Size = new System.Drawing.Size(44, 17);
            this.lblPreis.TabIndex = 44;
            this.lblPreis.Text = "Preis:";
            // 
            // lblProduktnr
            // 
            this.lblProduktnr.AutoSize = true;
            this.lblProduktnr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduktnr.Location = new System.Drawing.Point(60, 133);
            this.lblProduktnr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProduktnr.Name = "lblProduktnr";
            this.lblProduktnr.Size = new System.Drawing.Size(76, 17);
            this.lblProduktnr.TabIndex = 43;
            this.lblProduktnr.Text = "ProduktNr:";
            // 
            // frmProduktBearbeiten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 595);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmProduktBearbeiten";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produkt Bearbeiten";
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
    }
}