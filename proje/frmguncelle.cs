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
    public partial class frmguncelle : Form
    {
        public frmguncelle()
        {
            InitializeComponent();
        }
        SqlConnection bgl = new SqlConnection("Data Source=DESKTOP-1VBH1A8\\SSQL;Initial Catalog=oopproje;Integrated Security=True");
        private void frmguncelle_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from tblhasta", bgl);
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
            SqlCommand komutkarsilastir = new SqlCommand("select hastatarih,hastasaat from tblhasta where hastatarih=@p1 and hastasaat=@p2 and hastatc!=@p3", bgl);
            komutkarsilastir.Parameters.AddWithValue("@p1", msktarih.Text);
            komutkarsilastir.Parameters.AddWithValue("@p2", msksaat.Text);
            komutkarsilastir.Parameters.AddWithValue("@p3", txttc.Text);
            SqlDataReader dr = komutkarsilastir.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Lütfen farklı bir tarih veya saat seçiniz");
            }
            else
            {
                MessageBox.Show("Uygun bir saat ve tarih girdiniz lütfen kişisel bilgilerinizi girerek kayıt işlemine devam ediniz:");
                btnguncelle.Enabled = true;
                txtad.Enabled = true;
                txtsoyad.Enabled = true;
                
                txttel.Enabled = true;
                btnkontrol.Enabled = false;
                dateTimePicker1.Enabled = false;
                comboBox1.Enabled = false;
            }
            bgl.Close();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            int u = txttc.TextLength;
            int t = txttel.TextLength;

            if (u != 11 || t != 10 || string.IsNullOrEmpty(txtad.Text) || string.IsNullOrEmpty(txtsoyad.Text) || string.IsNullOrEmpty(txttc.Text) || string.IsNullOrEmpty(txttel.Text))
            {
                MessageBox.Show("Lütfen eksik ve boş alan bırakmayınız");
                if (u != 11)
                {
                    pictureBox3.Visible = true;
                }
                if (t != 10)
                {
                    pictureBox4.Visible = true;
                }
            }
            else
            {
                bgl.Open();
                SqlCommand komutguncelle = new SqlCommand("update tblhasta set hastaad=@p1,hastasoyad=@p2,hastatelefon=@p3,hastatarih=@p4,hastasaat=@p5 where hastatc=@p6", bgl);
                komutguncelle.Parameters.AddWithValue("@p1", txtad.Text);
                komutguncelle.Parameters.AddWithValue("@p2", txtsoyad.Text);
                komutguncelle.Parameters.AddWithValue("@p3", txttel.Text);
                komutguncelle.Parameters.AddWithValue("@p4", msktarih.Text);
                komutguncelle.Parameters.AddWithValue("@p5", msksaat.Text);
                komutguncelle.Parameters.AddWithValue("@p6", txttc.Text);
                komutguncelle.ExecuteNonQuery();
                MessageBox.Show("Kayıt başarılı şekilde güncellenmiştir.");
                SqlDataAdapter da = new SqlDataAdapter("select * from tblhasta", bgl);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                txtad.Enabled = false;
                txtsoyad.Enabled = false;
                txttc.Enabled = false;
                txttel.Enabled = false;
                btnguncelle.Enabled = false;
                dateTimePicker1.Enabled = false;
                comboBox1.Enabled = false;
                btnkontrol.Enabled = false;
                btnguncelle.Enabled = false;


            }
            bgl.Close();
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
            pictureBox3.Visible = false;
        }

        private void txttel_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand tckontrol = new SqlCommand("select * from tblhasta where hastatc=@p1", bgl);
            tckontrol.Parameters.AddWithValue("@p1", txttc.Text);
            SqlDataReader dr3 = tckontrol.ExecuteReader();
            if (dr3.Read())
            {
                txtad.Text = dr3[0].ToString();
                txtsoyad.Text = dr3[1].ToString();
                txttel.Text = dr3[3].ToString();
                dateTimePicker1.Enabled = true;
                comboBox1.Enabled = true;
                btnkontrol.Enabled = true;
                
                MessageBox.Show("Kişisel bilgileriniz getirilmiştir lütfen tarih seçiniz");
            }
            else
            {
                MessageBox.Show("Lütfen sistemde kayıtlı olan bir tc seçiniz");
            }
            bgl.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txttc.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtad.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txttel.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            msktarih.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            msksaat.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btnyenile_Click(object sender, EventArgs e)
        {
            txtad.Text = "";
            txtsoyad.Text = "";
            txttc.Text = "";
            txttel.Text = "";
            msksaat.Text = "";
            msktarih.Text = "";
        }
    }
}
