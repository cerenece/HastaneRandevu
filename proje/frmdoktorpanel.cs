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

    public partial class frmdoktorpanel : Form
    {
        public frmdoktorpanel()
        {
            InitializeComponent();

        }
        SqlConnection bgl = new SqlConnection("Data Source=DESKTOP-1VBH1A8\\SSQL;Initial Catalog=oopproje;Integrated Security=True");

        public void yenile()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from tblhasta", bgl);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btntemizle_Click(object sender, EventArgs e)
          {
            txtad.Text = "";
            txtsoyad.Text = "";
            txttc.Text = "";
            txttel.Text = "";
            msksaat.Text = "";
            msktarih.Text = "";
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
          private void btngüncelle_Click(object sender, EventArgs e)
          {
            frmguncelle fr = new frmguncelle();
            fr.Show();
            this.Hide();
          }
          private void btnsil_Click(object sender, EventArgs e)
          {
            if (string.IsNullOrEmpty(txttc.Text))
            {
                MessageBox.Show("Lütfen bir kayıt seçiniz");
            }
            else
            {
                bgl.Open();
                SqlCommand komutsil = new SqlCommand("delete from tblhasta where hastatc=@p1", bgl);
                komutsil.Parameters.AddWithValue("@p1", txttc.Text);
                komutsil.ExecuteNonQuery();


                bgl.Close();
                MessageBox.Show("Kayıt başarı ile silinmiştir");
                yenile();
                btnsil.Enabled = false;
                button1.Enabled = true;
                txtad.Text = "";
                txtsoyad.Text = "";
                txttc.Text = "";
                txttel.Text = "";
                msksaat.Text = "";
                msktarih.Text = "";

            }


          }
          private void frmdoktorpanel_Load(object sender, EventArgs e)
          {
            yenile();
            comboBox1.SelectedIndex = 0;
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
            SqlDataReader dr2 = tckontrol.ExecuteReader();
            if (dr2.Read())
            {
                btnsil.Enabled = true;
                button1.Enabled = false;
                
                MessageBox.Show("Kayıtlı bir tc numarası seçtiniz lütfen işleminize devam ediniz");
                
            }
            else
            {
                MessageBox.Show("Lütfen sistemde kayıtlı olan bir tc seçiniz");
            }
            bgl.Close();
        }
    }


}

           