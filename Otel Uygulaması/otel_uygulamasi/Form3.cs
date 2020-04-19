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
using System.Data.SqlTypes;
using System.Data.Sql;

namespace otel_uygulamasi
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-EJFO9BT;Initial Catalog=xxx;Integrated Security=True");




        void listele()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * From müsteri ", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-EJFO9BT;Initial Catalog=xxx;Integrated Security=True");
            con.Open();
            String a = "INSERT INTO müsteri (Ad,Soyad,Adres,Telefon,Email,Oda,Kat,YatakSayisi,BanyoSayisi,Cephe,GirisTarihi,CikisTarihi,Odeme_türü,Tutar) VALUES('" + t1.Text + "','" + t2.Text + "','" + t3.Text + "','" + t4.Text + "','" + t5.Text + "','" + c1.Text + "','" + t6.Text + "','" + t7.Text + "','" + t8.Text + "','" + t9.Text + "','" + d1.Text + "','" + d2.Text + "','" + c2.Text + "','" + t10.Text + "')";
            SqlDataAdapter x = new SqlDataAdapter(a, con);
            x.SelectCommand.ExecuteNonQuery();
            con.Close();
            listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 geridon = new Form2();
            this.Hide();
            geridon.Show();
        }

    

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "DELETE FROM müsteri where id ='" + sil.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Kayıt Başarılı Bir Şekilde Silindi.");
            listele();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            listele();

        }

        

        private void dataGridView1_MouseDoubleClick(object sender, EventArgs e)
        {
            sil.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void t7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void c1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void c1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
            if ((char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void c2_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void c2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
            if ((char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}
