using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SarkiListe
{
    public partial class FormEkle : Form
    {

        string baglanti = "Server=localhost;Database=muzik;Uid=root;Pwd=''";
        public FormEkle()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(baglanti))
            {
                string sql = "INSERT INTO sarkilar (ad,sanatci,yil,tur,sure,eklenme_tarihi,favori) VALUES (@ad,@sanatci,@yil,@tur,@sure,@eklenme_tarihi,@favori)";
                
                con.Open();

                MySqlCommand cmd = new MySqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@ad", txtSarkiAd.Text);
                cmd.Parameters.AddWithValue("@sanatci", txtSanatci.Text);
                cmd.Parameters.AddWithValue("@yil", txtYil.Text);
                cmd.Parameters.AddWithValue("@tur", cmbTur.Text);
                cmd.Parameters.AddWithValue("@sure", txtSure.Text);
                cmd.Parameters.AddWithValue("@eklenme_tarihi", dtpTarih.Value);
                cmd.Parameters.AddWithValue("@favori", chkFavori.Checked);
                

                //cmd.ExecuteNonQuery();

                DialogResult result = MessageBox.Show("Kayıt eklensin mi?", "Kayıt Ekle", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();

                }

                txtSarkiAd.Clear();
                txtSanatci.Clear();
                txtSure.Clear();
                txtYil.Clear();
                cmbTur.Text = "";
                chkFavori.Checked = false;


            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
