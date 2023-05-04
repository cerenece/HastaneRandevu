using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace oop3
{
    public partial class frmhastakayit : Form
    {
        public frmhastakayit()
        {
            InitializeComponent();
        }

        SqlConnection bgl = new SqlConnection("Data Source=DESKTOP-1VBH1A8\\SSQL;Initial Catalog=oopproje;Integrated Security=True");
        private void frmhastakayit_Load(object sender, EventArgs e)
        {
            SqlCommand komutgoster = new SqlCommand("select hastatarih,hastasaat from tblhasta ", bgl);
            SqlDataAdapter da = new SqlDataAdapter(komutgoster);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            comboBox1.SelectedIndex = 0;
        }

        private void btnkontrol_Click(object sender, EventArgs e)
        {
            string date = dateTimePicker1.Value.ToShortDateString();
            msktarih.Text = date;
            string time = comboBox1.Text;
            msksaat.Text = time;

            bgl.Open();
            SqlCommand komutkarsilastir = new SqlCommand("select hastatarih,hastasaat from tblhasta where hastatarih=@p1 and hastasaat=@p2", bgl);
            komutkarsilastir.Parameters.AddWithValue("@p1", msktarih.Text);
            komutkarsilastir.Parameters.AddWithValue("@p2", msksaat.Text);
            SqlDataReader dr = komutkarsilastir.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Lütfen farklı bir tarih veya saat seçiniz");
            }
            else
            {
                MessageBox.Show("Uygun bir saat ve tarih girdiniz lütfen kişisel bilgilerinizi girerek kayıt işlemine devam ediniz:");
                btnkayıt.Enabled = true;
                txtad.Enabled = true;
                txtsoyad.Enabled = true;
                txttc.Enabled = true;
                txttel.Enabled = true;
                btnkontrol.Enabled = false;
                dateTimePicker1.Enabled = false;
                comboBox1.Enabled = false;
                
            }
            bgl.Close();

        }

        private void btnkayıt_Click(object sender, EventArgs e)
        {
            int u = Convert.ToInt32(txttc.TextLength);
            int t = Convert.ToInt32(txttel.TextLength);

            if (u != 11 || t != 10 || string.IsNullOrEmpty(txtad.Text) || string.IsNullOrEmpty(txtsoyad.Text) || string.IsNullOrEmpty(txttc.Text) || string.IsNullOrEmpty(txttel.Text))
            {
                MessageBox.Show("Lütfen eksik ve boş alan bırakmayınız");
                if (u != 11)
                {
                    pictureBox5.Visible = true;
                }
                if (t != 10)
                {
                    pictureBox6.Visible = true;
                }
            }

            else
            {
                bgl.Open();
                SqlCommand komut = new SqlCommand("insert into tblhasta (hastatc,hastaad,hastasoyad,hastatelefon,hastatarih,hastasaat) values (@p1,@p2,@p3,@p4,@p5,@p6) ", bgl);
                komut.Parameters.AddWithValue("@p1", txttc.Text);
                komut.Parameters.AddWithValue("@p2", txtad.Text);
                komut.Parameters.AddWithValue("@p3", txtsoyad.Text);
                komut.Parameters.AddWithValue("@p4", txttel.Text);
                komut.Parameters.AddWithValue("@p5", msktarih.Text);
                komut.Parameters.AddWithValue("@p6", msksaat.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Kaydınızı başarı ile oluşturulmuştur");
                bgl.Close();
                SqlCommand komutgoster = new SqlCommand("select hastatarih,hastasaat from tblhasta ", bgl);
                SqlDataAdapter da = new SqlDataAdapter(komutgoster);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                txtad.Enabled = false;
                txtsoyad.Enabled = false;
                txttc.Enabled = false;
                txttel.Enabled = false;
                btnkayıt.Enabled = false;
                dateTimePicker1.Enabled = true;
                comboBox1.Enabled = true;
                btnkontrol.Enabled = true;



            }
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            frmgiris fr = new frmgiris();
            fr.Show();
            this.Hide();
        }

        private void txtad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void txtsoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void txttc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txttel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txttc_Click(object sender, EventArgs e)
        {
            pictureBox5.Visible = false;
        }

        private void txttel_Click(object sender, EventArgs e)
        {
            pictureBox6.Visible = false;
        }
    }
}
