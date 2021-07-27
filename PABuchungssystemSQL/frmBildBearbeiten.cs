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

namespace PABuchungssystemSQL
{
    public partial class frmBildBearbeiten : Form
    {
        public frmBildBearbeiten()
        {
            InitializeComponent();
        }

        private void BildUpdate(string pfad, byte[] image, int produktnr)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(Helper.CnnVal("managementDB")))
                {
                    sqlConn.Open();
                    cmd.Connection = sqlConn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update produkte set pfad = @pfad, image = @image where produktnr = @produktnr";
                    cmd.Parameters.AddWithValue("@pfad", txtPfad.Text);
                    cmd.Parameters.AddWithValue("@image", image);
                    cmd.Parameters.AddWithValue("@produktnr", produktnr);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            using(OpenFileDialog ofd = new OpenFileDialog() { Filter = "Image files(*.jpg; *.jpeg) | *.jpg | *.jpeg",
            Multiselect = false})
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    picProdukt.Image = Image.FromFile(ofd.FileName);
                    txtPfad.Text = ofd.FileName;
                    BildUpdate(txtPfad.Text, ConvertImageToByteArray(picProdukt.Image), 1);
                }
            }
        }
    }
}
