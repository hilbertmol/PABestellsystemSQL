
namespace PABuchungssystemSQL
{
    partial class frmBestellungBearbeiten
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
            this.txtKundennr = new System.Windows.Forms.TextBox();
            this.lblKundennr = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.txtProduktnr = new System.Windows.Forms.TextBox();
            this.txtBestellungsnr = new System.Windows.Forms.TextBox();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblProduktnr = new System.Windows.Forms.Label();
            this.lblBestellungsnr = new System.Windows.Forms.Label();
            this.dtpBestellungDate = new System.Windows.Forms.DateTimePicker();
            this.dtpBestellungTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnAbbrechen
            // 
            this.btnAbbrechen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbbrechen.Location = new System.Drawing.Point(319, 384);
            this.btnAbbrechen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAbbrechen.Name = "btnAbbrechen";
            this.btnAbbrechen.Size = new System.Drawing.Size(120, 30);
            this.btnAbbrechen.TabIndex = 62;
            this.btnAbbrechen.Text = "Abbrechen";
            this.btnAbbrechen.UseVisualStyleBackColor = true;
            this.btnAbbrechen.Click += new System.EventHandler(this.btnAbbrechen_Click);
            // 
            // txtKundennr
            // 
            this.txtKundennr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKundennr.Location = new System.Drawing.Point(184, 215);
            this.txtKundennr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtKundennr.Name = "txtKundennr";
            this.txtKundennr.Size = new System.Drawing.Size(255, 23);
            this.txtKundennr.TabIndex = 51;
            // 
            // lblKundennr
            // 
            this.lblKundennr.AutoSize = true;
            this.lblKundennr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKundennr.Location = new System.Drawing.Point(70, 218);
            this.lblKundennr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKundennr.Name = "lblKundennr";
            this.lblKundennr.Size = new System.Drawing.Size(76, 17);
            this.lblKundennr.TabIndex = 50;
            this.lblKundennr.Text = "KundenNr:";
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(184, 384);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(120, 30);
            this.btnOK.TabIndex = 49;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtDatum
            // 
            this.txtDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatum.Location = new System.Drawing.Point(184, 294);
            this.txtDatum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(255, 23);
            this.txtDatum.TabIndex = 48;
            // 
            // txtProduktnr
            // 
            this.txtProduktnr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProduktnr.Location = new System.Drawing.Point(184, 256);
            this.txtProduktnr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtProduktnr.Name = "txtProduktnr";
            this.txtProduktnr.Size = new System.Drawing.Size(255, 23);
            this.txtProduktnr.TabIndex = 47;
            // 
            // txtBestellungsnr
            // 
            this.txtBestellungsnr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBestellungsnr.Location = new System.Drawing.Point(184, 172);
            this.txtBestellungsnr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBestellungsnr.Name = "txtBestellungsnr";
            this.txtBestellungsnr.Size = new System.Drawing.Size(255, 23);
            this.txtBestellungsnr.TabIndex = 46;
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatum.Location = new System.Drawing.Point(70, 297);
            this.lblDatum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(53, 17);
            this.lblDatum.TabIndex = 45;
            this.lblDatum.Text = "Datum:";
            // 
            // lblProduktnr
            // 
            this.lblProduktnr.AutoSize = true;
            this.lblProduktnr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduktnr.Location = new System.Drawing.Point(70, 258);
            this.lblProduktnr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProduktnr.Name = "lblProduktnr";
            this.lblProduktnr.Size = new System.Drawing.Size(76, 17);
            this.lblProduktnr.TabIndex = 44;
            this.lblProduktnr.Text = "ProduktNr:";
            // 
            // lblBestellungsnr
            // 
            this.lblBestellungsnr.AutoSize = true;
            this.lblBestellungsnr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBestellungsnr.Location = new System.Drawing.Point(70, 175);
            this.lblBestellungsnr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBestellungsnr.Name = "lblBestellungsnr";
            this.lblBestellungsnr.Size = new System.Drawing.Size(100, 17);
            this.lblBestellungsnr.TabIndex = 43;
            this.lblBestellungsnr.Text = "BestellungsNr:";
            // 
            // dtpBestellungDate
            // 
            this.dtpBestellungDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBestellungDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBestellungDate.Location = new System.Drawing.Point(184, 322);
            this.dtpBestellungDate.Name = "dtpBestellungDate";
            this.dtpBestellungDate.Size = new System.Drawing.Size(120, 23);
            this.dtpBestellungDate.TabIndex = 63;
            this.dtpBestellungDate.ValueChanged += new System.EventHandler(this.dtpBestellung_ValueChanged);
            // 
            // dtpBestellungTime
            // 
            this.dtpBestellungTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBestellungTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpBestellungTime.Location = new System.Drawing.Point(319, 322);
            this.dtpBestellungTime.Name = "dtpBestellungTime";
            this.dtpBestellungTime.ShowUpDown = true;
            this.dtpBestellungTime.Size = new System.Drawing.Size(120, 23);
            this.dtpBestellungTime.TabIndex = 64;
            this.dtpBestellungTime.ValueChanged += new System.EventHandler(this.dtpBestellung_ValueChanged);
            // 
            // frmBestellungBearbeiten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 595);
            this.Controls.Add(this.dtpBestellungTime);
            this.Controls.Add(this.dtpBestellungDate);
            this.Controls.Add(this.btnAbbrechen);
            this.Controls.Add(this.txtKundennr);
            this.Controls.Add(this.lblKundennr);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.txtProduktnr);
            this.Controls.Add(this.txtBestellungsnr);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.lblProduktnr);
            this.Controls.Add(this.lblBestellungsnr);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmBestellungBearbeiten";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bestellung Bearbeiten";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAbbrechen;
        private System.Windows.Forms.TextBox txtKundennr;
        private System.Windows.Forms.Label lblKundennr;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.TextBox txtProduktnr;
        private System.Windows.Forms.TextBox txtBestellungsnr;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblProduktnr;
        private System.Windows.Forms.Label lblBestellungsnr;
        private System.Windows.Forms.DateTimePicker dtpBestellungDate;
        private System.Windows.Forms.DateTimePicker dtpBestellungTime;
    }
}