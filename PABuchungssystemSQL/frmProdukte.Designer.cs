
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdukte)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAktualisieren
            // 
            this.btnAktualisieren.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAktualisieren.Location = new System.Drawing.Point(195, 735);
            this.btnAktualisieren.Name = "btnAktualisieren";
            this.btnAktualisieren.Size = new System.Drawing.Size(160, 37);
            this.btnAktualisieren.TabIndex = 42;
            this.btnAktualisieren.Text = "Aktualisieren";
            this.btnAktualisieren.UseVisualStyleBackColor = true;
            // 
            // btnLöschen
            // 
            this.btnLöschen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLöschen.Location = new System.Drawing.Point(380, 735);
            this.btnLöschen.Name = "btnLöschen";
            this.btnLöschen.Size = new System.Drawing.Size(160, 37);
            this.btnLöschen.TabIndex = 41;
            this.btnLöschen.Text = "Löschen";
            this.btnLöschen.UseVisualStyleBackColor = true;
            // 
            // lblUeberschriftProdukte
            // 
            this.lblUeberschriftProdukte.BackColor = System.Drawing.Color.SteelBlue;
            this.lblUeberschriftProdukte.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUeberschriftProdukte.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUeberschriftProdukte.Location = new System.Drawing.Point(1, 24);
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
            this.dgvProdukte.Name = "dgvProdukte";
            this.dgvProdukte.RowHeadersWidth = 51;
            this.dgvProdukte.RowTemplate.Height = 24;
            this.dgvProdukte.Size = new System.Drawing.Size(1295, 600);
            this.dgvProdukte.TabIndex = 39;
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(12, 735);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(160, 37);
            this.btnInsert.TabIndex = 38;
            this.btnInsert.Text = "Einfügen";
            this.btnInsert.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(1118, 845);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(160, 37);
            this.btnSearch.TabIndex = 37;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // lblProduktnr
            // 
            this.lblProduktnr.AutoSize = true;
            this.lblProduktnr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduktnr.Location = new System.Drawing.Point(773, 738);
            this.lblProduktnr.Name = "lblProduktnr";
            this.lblProduktnr.Size = new System.Drawing.Size(111, 25);
            this.lblProduktnr.TabIndex = 36;
            this.lblProduktnr.Text = "ProduktNr:";
            // 
            // txtProduktnr
            // 
            this.txtProduktnr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProduktnr.Location = new System.Drawing.Point(939, 735);
            this.txtProduktnr.Name = "txtProduktnr";
            this.txtProduktnr.Size = new System.Drawing.Size(339, 26);
            this.txtProduktnr.TabIndex = 35;
            // 
            // lblProduktname
            // 
            this.lblProduktname.AutoSize = true;
            this.lblProduktname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduktname.Location = new System.Drawing.Point(773, 786);
            this.lblProduktname.Name = "lblProduktname";
            this.lblProduktname.Size = new System.Drawing.Size(140, 25);
            this.lblProduktname.TabIndex = 44;
            this.lblProduktname.Text = "Produktname:";
            // 
            // txtProduktname
            // 
            this.txtProduktname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProduktname.Location = new System.Drawing.Point(939, 783);
            this.txtProduktname.Name = "txtProduktname";
            this.txtProduktname.Size = new System.Drawing.Size(339, 26);
            this.txtProduktname.TabIndex = 43;
            // 
            // frmProdukte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 954);
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
            this.Name = "frmProdukte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produkte";
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
    }
}