using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SarkiListe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string baglanti = "Server=localhost;Database=muzik;Uid=root;Pwd=''";

        DataTable dt;
        
        void TumVerileriGetir()
        {
            using (MySqlConnection con = new MySqlConnection(baglanti))
            {

                string sql = "SELECT *FROM sarkilar";
                con.Open();

                MySqlCommand cmd = new MySqlCommand(sql, con);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                dt = new DataTable();

                da.Fill(dt);

                dgvListe.DataSource = dt;
                dgvListe.Invalidate();
                dgvListe.Refresh();

            }
        }

        void VeriFiltrele(string sql)
        {
            using (MySqlConnection con = new MySqlConnection(baglanti))
            {

                //string sql = "SELECT *FROM sarkilar WHERE ad LIKE '%"+txtAra.Text+"%'";
                con.Open();

                MySqlCommand cmd = new MySqlCommand(sql, con);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                dt = new DataTable();

                da.Fill(dt);

                dgvListe.DataSource = dt;
                dgvListe.Invalidate();
                dgvListe.Refresh();

            }
        }




        void TurleriGetir()
        {
            using (MySqlConnection con = new MySqlConnection(baglanti))
            {

                string sql = "SELECT DISTINCT tur FROM sarkilar";
                con.Open();

                MySqlCommand cmd = new MySqlCommand(sql, con);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                cmbTur.DataSource = dt;

                cmbTur.DisplayMember = "tur";
                cmbTur.ValueMember = "tur";

            }
        }


                                                         

        private void Form1_Load(object sender, EventArgs e)
        {

            TumVerileriGetir();
            TurleriGetir();

            
        }

        private void dgvListe_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvListe.CurrentRow.Cells["id"].Value.ToString();
            txtSarkiAd.Text = dgvListe.CurrentRow.Cells["ad"].Value.ToString();
            txtSanatci.Text = dgvListe.CurrentRow.Cells["sanatci"].Value.ToString();            
            txtYil.Text = dgvListe.CurrentRow.Cells["yil"].Value.ToString();
            cmbTur.Text= dgvListe.CurrentRow.Cells["tur"].Value.ToString();
            txtSure.Text = dgvListe.CurrentRow.Cells["sure"].Value.ToString();            
            dtpEklenmeTarihi.Value = Convert.ToDateTime(dgvListe.CurrentRow.Cells["eklenme_tarihi"].Value);
            chkFavori.Checked = Convert.ToBoolean(dgvListe.CurrentRow.Cells["favori"].Value);

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            using(MySqlConnection con=new MySqlConnection(baglanti))
            {
                string sql = "DELETE FROM sarkilar WHERE id=@id";
                int secilenId = Convert.ToInt32(txtId.Text);
                //int secilenId = Convert.ToInt32(dgvListe.CurrentRow.Cells["id"].Value.ToString());
                con.Open();

                MySqlCommand cmd=new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id",secilenId);

                //cmd.ExecuteNonQuery();

                DialogResult result = MessageBox.Show("Kayıt silinsin mi?", "Kayıt Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if(result == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    TumVerileriGetir();
                }


            }






        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            

            using (MySqlConnection con = new MySqlConnection(baglanti))
            {
                string sql = "UPDATE sarkilar SET ad=@ad, sanatci=@sanatci,yil=@yil,tur=@tur,sure=@sure,eklenme_tarihi=@eklenme_tarihi,favori=@favori WHERE id=@id;";
                int secilenId = Convert.ToInt32(txtId.Text);
                //int secilenId = Convert.ToInt32(dgvListe.CurrentRow.Cells["id"].Value.ToString());
                con.Open();

                MySqlCommand cmd = new MySqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@ad",txtSarkiAd.Text);
                cmd.Parameters.AddWithValue("@sanatci",txtSanatci.Text);
                cmd.Parameters.AddWithValue("@yil",txtYil.Text);
                cmd.Parameters.AddWithValue("@tur",cmbTur.Text);
                cmd.Parameters.AddWithValue("@sure",txtSure.Text);
                cmd.Parameters.AddWithValue("@eklenme_tarihi",dtpEklenmeTarihi.Value);
                cmd.Parameters.AddWithValue("@favori",chkFavori.Checked);
                cmd.Parameters.AddWithValue("@id", secilenId);

                

                DialogResult result = MessageBox.Show("Kayıt güncellensin mi?", "Kayıt Güncelle", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    TumVerileriGetir();
                }


            }


        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FormEkle formEkle=new FormEkle();
            formEkle.ShowDialog();
            TumVerileriGetir();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            string sql = "";
            
            if(rbSarkiAra.Checked)
            {
                 sql = "SELECT *FROM sarkilar WHERE ad LIKE '%" + txtAra.Text + "%'";
            }

            else
            {
                 sql = "SELECT *FROM sarkilar WHERE sanatci LIKE '%" + txtAra.Text + "%'";
            }

            VeriFiltrele(sql);



        }
    }
}
