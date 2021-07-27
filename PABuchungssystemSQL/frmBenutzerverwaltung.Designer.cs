
namespace PABuchungssystemSQL
{
    partial class frmBenutzerverwaltung
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
            this.lblUeberschriftBestellungen = new System.Windows.Forms.Label();
            this.dgvBenutzer = new System.Windows.Forms.DataGridView();
            this.lblLoginA = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblNachnameA = new System.Windows.Forms.Label();
            this.lblNachname = new System.Windows.Forms.Label();
            this.lblEmailA = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTypA = new System.Windows.Forms.Label();
            this.lblTyp = new System.Windows.Forms.Label();
            this.lblVornameA = new System.Windows.Forms.Label();
            this.lblVorname = new System.Windows.Forms.Label();
            this.btnZurueck = new System.Windows.Forms.Button();
            this.btnVor = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBenutzer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUeberschriftBestellungen
            // 
            this.lblUeberschriftBestellungen.BackColor = System.Drawing.Color.SteelBlue;
            this.lblUeberschriftBestellungen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUeberschriftBestellungen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUeberschriftBestellungen.Location = new System.Drawing.Point(1, 23);
            this.lblUeberschriftBestellungen.Name = "lblUeberschriftBestellungen";
            this.lblUeberschriftBestellungen.Size = new System.Drawing.Size(1317, 49);
            this.lblUeberschriftBestellungen.TabIndex = 33;
            this.lblUeberschriftBestellungen.Text = "Benutzerverwaltung";
            this.lblUeberschriftBestellungen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvBenutzer
            // 
            this.dgvBenutzer.AllowUserToAddRows = false;
            this.dgvBenutzer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBenutzer.Location = new System.Drawing.Point(65, 494);
            this.dgvBenutzer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvBenutzer.Name = "dgvBenutzer";
            this.dgvBenutzer.RowHeadersWidth = 51;
            this.dgvBenutzer.RowTemplate.Height = 24;
            this.dgvBenutzer.Size = new System.Drawing.Size(1184, 432);
            this.dgvBenutzer.TabIndex = 40;
            this.dgvBenutzer.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvBenutzer_CellFormatting);
            this.dgvBenutzer.SelectionChanged += new System.EventHandler(this.dgvBenutzer_SelectionChanged);
            // 
            // lblLoginA
            // 
            this.lblLoginA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLoginA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginA.Location = new System.Drawing.Point(237, 96);
            this.lblLoginA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoginA.Name = "lblLoginA";
            this.lblLoginA.Size = new System.Drawing.Size(221, 33);
            this.lblLoginA.TabIndex = 47;
            this.lblLoginA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(61, 102);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(55, 20);
            this.lblLogin.TabIndex = 46;
            this.lblLogin.Text = "Login:";
            // 
            // lblNachnameA
            // 
            this.lblNachnameA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNachnameA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNachnameA.Location = new System.Drawing.Point(237, 206);
            this.lblNachnameA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNachnameA.Name = "lblNachnameA";
            this.lblNachnameA.Size = new System.Drawing.Size(221, 33);
            this.lblNachnameA.TabIndex = 51;
            this.lblNachnameA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNachname
            // 
            this.lblNachname.AutoSize = true;
            this.lblNachname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNachname.Location = new System.Drawing.Point(61, 212);
            this.lblNachname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNachname.Name = "lblNachname";
            this.lblNachname.Size = new System.Drawing.Size(94, 20);
            this.lblNachname.TabIndex = 50;
            this.lblNachname.Text = "Nachname:";
            // 
            // lblEmailA
            // 
            this.lblEmailA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEmailA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailA.Location = new System.Drawing.Point(237, 260);
            this.lblEmailA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmailA.Name = "lblEmailA";
            this.lblEmailA.Size = new System.Drawing.Size(221, 33);
            this.lblEmailA.TabIndex = 53;
            this.lblEmailA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(61, 266);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(56, 20);
            this.lblEmail.TabIndex = 52;
            this.lblEmail.Text = "Email:";
            // 
            // lblTypA
            // 
            this.lblTypA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTypA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypA.Location = new System.Drawing.Point(237, 316);
            this.lblTypA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTypA.Name = "lblTypA";
            this.lblTypA.Size = new System.Drawing.Size(221, 33);
            this.lblTypA.TabIndex = 55;
            this.lblTypA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTyp
            // 
            this.lblTyp.AutoSize = true;
            this.lblTyp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTyp.Location = new System.Drawing.Point(61, 322);
            this.lblTyp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTyp.Name = "lblTyp";
            this.lblTyp.Size = new System.Drawing.Size(41, 20);
            this.lblTyp.TabIndex = 54;
            this.lblTyp.Text = "Typ:";
            // 
            // lblVornameA
            // 
            this.lblVornameA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVornameA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVornameA.Location = new System.Drawing.Point(237, 151);
            this.lblVornameA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVornameA.Name = "lblVornameA";
            this.lblVornameA.Size = new System.Drawing.Size(221, 33);
            this.lblVornameA.TabIndex = 49;
            this.lblVornameA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVorname
            // 
            this.lblVorname.AutoSize = true;
            this.lblVorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVorname.Location = new System.Drawing.Point(61, 158);
            this.lblVorname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVorname.Name = "lblVorname";
            this.lblVorname.Size = new System.Drawing.Size(81, 20);
            this.lblVorname.TabIndex = 48;
            this.lblVorname.Text = "Vorname:";
            // 
            // btnZurueck
            // 
            this.btnZurueck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZurueck.Location = new System.Drawing.Point(552, 96);
            this.btnZurueck.Margin = new System.Windows.Forms.Padding(4);
            this.btnZurueck.Name = "btnZurueck";
            this.btnZurueck.Size = new System.Drawing.Size(80, 74);
            this.btnZurueck.TabIndex = 56;
            this.btnZurueck.Text = "<";
            this.btnZurueck.UseVisualStyleBackColor = true;
            this.btnZurueck.Click += new System.EventHandler(this.btnZurueck_Click);
            // 
            // btnVor
            // 
            this.btnVor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVor.Location = new System.Drawing.Point(665, 96);
            this.btnVor.Margin = new System.Windows.Forms.Padding(4);
            this.btnVor.Name = "btnVor";
            this.btnVor.Size = new System.Drawing.Size(80, 74);
            this.btnVor.TabIndex = 57;
            this.btnVor.Text = ">";
            this.btnVor.UseVisualStyleBackColor = true;
            this.btnVor.Click += new System.EventHandler(this.btnVor_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(65, 417);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(160, 37);
            this.btnSearch.TabIndex = 58;
            this.btnSearch.Text = "Neu";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(249, 417);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 37);
            this.button3.TabIndex = 59;
            this.button3.Text = "Aktualisieren";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnAktualisieren_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(435, 417);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(160, 37);
            this.button4.TabIndex = 60;
            this.button4.Text = "Löschen";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnLöschen_Click);
            // 
            // frmBenutzerverwaltung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 954);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnVor);
            this.Controls.Add(this.btnZurueck);
            this.Controls.Add(this.lblTypA);
            this.Controls.Add(this.lblTyp);
            this.Controls.Add(this.lblEmailA);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNachnameA);
            this.Controls.Add(this.lblNachname);
            this.Controls.Add(this.lblVornameA);
            this.Controls.Add(this.lblVorname);
            this.Controls.Add(this.lblLoginA);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.dgvBenutzer);
            this.Controls.Add(this.lblUeberschriftBestellungen);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBenutzerverwaltung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Benutzerverwaltung";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBestellungen_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBenutzer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUeberschriftBestellungen;
        private System.Windows.Forms.DataGridView dgvBenutzer;
        private System.Windows.Forms.Label lblLoginA;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblNachnameA;
        private System.Windows.Forms.Label lblNachname;
        private System.Windows.Forms.Label lblEmailA;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTypA;
        private System.Windows.Forms.Label lblTyp;
        private System.Windows.Forms.Label lblVornameA;
        private System.Windows.Forms.Label lblVorname;
        private System.Windows.Forms.Button btnZurueck;
        private System.Windows.Forms.Button btnVor;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}