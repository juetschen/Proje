using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otel_uygulamasi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            Application.Exit();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 kayit = new Form3();
            this.Hide();
            kayit.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 cik = new Form1();
            cik.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
