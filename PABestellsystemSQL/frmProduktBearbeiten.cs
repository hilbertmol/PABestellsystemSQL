using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PABestellsystemSQL
{
    public partial class frmProduktBearbeiten : Form
    {
        public frmProduktBearbeiten()
        {
            InitializeComponent();
            picProdukt.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        public void EditProdukt(DataRowView drv)
        {
            SqlDataAdapter sqlDa = new SqlDataAdapter();
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            string cmdStr = "";
            try
            {
                if (drv.Row.RowState == DataRowState.Detached)
                {
                    txtProduktnr.Text = "";
                    txtProduktname.Text = "";
                    txtPreis.Text = "";
                    txtBeschreibung.Text = "";
                    txtHersteller.Text = "";
                    txtKategorie.Text = "";
                    txtStueckzahl.Text = "";
                    txtPfad.Text = "";
                }
                else
                {
                    txtProduktnr.Text = drv["produktnr"].ToString();
                    txtProduktname.Text = drv["produktname"].ToString();
                    txtPreis.Text = drv["preis"].ToString();
                    txtBeschreibung.Text = drv["beschreibung"].ToString();
                    txtHersteller.Text = drv["hersteller"].ToString();
                    txtKategorie.Text = drv["kategorie"].ToString();
                    txtStueckzahl.Text = drv["stueckzahl"].ToString();
                    txtPfad.Text = drv["pfad"].ToString();

                    //Bild laden aus der Datenbank

                    using (SqlConnection sqlConn = new SqlConnection(Helper.CnnVal("managementDB")))
                    {
                        cmdStr = "select image from produkte where produktnr = @produktnr";
                        cmd = new SqlCommand(cmdStr, sqlConn);
                        cmd.Parameters.AddWithValue("@produktnr", txtProduktnr.Text);
                        sqlDa.SelectCommand = cmd;
                        ds = new DataSet();
                        sqlDa.Fill(ds);
                    }

                    if (ds.Tables[0].Rows.Count == 1 && ds.Tables[0].Rows[0]["image"] != DBNull.Value)
                    {
                        Byte[] data = new byte[0];
                        data = (Byte[])(ds.Tables[0].Rows[0]["image"]);
                        MemoryStream ms = new MemoryStream(data);
                        picProdukt.Image = Image.FromStream(ms);
                    }
                }

                if (this.ShowDialog() == DialogResult.OK)
                {
                    cmd = new SqlCommand();
                    cmdStr = "";
                    double preis = Convert.ToDouble(txtPreis.Text);
                    string preisStr = (String.Format("{0:0.00}", preis)).Replace(',', '.');
                    byte[] image = ConvertImageToByteArray(picProdukt.Image);

                    if (drv.Row.RowState == DataRowState.Detached)
                    {
                        cmdStr = "insert into produkte values (@produktnr, @produktname, @preis, @beschreibung, " +
                        "@hersteller, @kategorie, @stueckzahl, @pfad, @image)";
                    }
                    else
                    {
                        cmdStr = "update produkte set produktname = @produktname" +
                                                    ", preis = @preis" +
                                                    ", beschreibung = @beschreibung" +
                                                    ", hersteller = @hersteller" +
                                                    ", kategorie = @kategorie" +
                                                    ", stueckzahl = @stueckzahl" +
                                                    ", pfad = @pfad" +
                                                    ", image = @image" +
                                                    " where produktnr = @produktnr";
                    }
                    using (SqlConnection sqlConn = new SqlConnection(Helper.CnnVal("managementDB")))
                    {
                        sqlConn.Open();
                        cmd.Connection = sqlConn;
                        cmd.CommandText = cmdStr;
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@produktnr", txtProduktnr.Text);
                        cmd.Parameters.AddWithValue("@produktname", txtProduktname.Text);
                        cmd.Parameters.AddWithValue("@preis", preisStr);
                        cmd.Parameters.AddWithValue("@beschreibung", txtBeschreibung.Text);
                        cmd.Parameters.AddWithValue("@hersteller", txtHersteller.Text);
                        cmd.Parameters.AddWithValue("@kategorie", txtKategorie.Text);
                        cmd.Parameters.AddWithValue("@stueckzahl", txtStueckzahl.Text);
                        cmd.Parameters.AddWithValue("@pfad", txtPfad.Text);
                        cmd.Parameters.AddWithValue("@image", image);
                        cmd.ExecuteNonQuery();
                    }
                }
                else
                {
                    drv.CancelEdit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAbbrechen_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        byte[] ConvertImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private Image ConvertByteArrayToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                return Image.FromStream(ms);
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "Image files(*.jpg)|*.jpg",
                Multiselect = false
            })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    picProdukt.Image = Image.FromFile(ofd.FileName);
                    txtPfad.Text = ofd.FileName;
                }
            }
        }
    }
}
