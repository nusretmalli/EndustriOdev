using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS1809
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        bool clear = false;
        string[] macaKodu = { "50227657", "50122043", "50119874", "50327233", "50134858", "50121725", "50121214", "50128028", "50411504" };
        string[] hamurTipi = { "EP", "CR", "NBR", "EP", "NBR", "CR", "EP", "NBR", "EP" };
        string[] hortumTipi = { "Soğutma Hortumu"};
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (((textBox1.Text == macaKodu[0]) && (textBox2.Text == hamurTipi[0])))
            {      
                for(int i = 0; i < 1; i++)
                {
                    label5.Visible = true;
                    label5.Text = hortumTipi[i];
                }
                    label6.Text = "30 cm";
                    label3.Visible = true;
                    label4.Visible = true;
                    label6.Visible = true;
                    label7.Visible = false;
            }
            else if (textBox1.Text == macaKodu[1] && textBox2.Text == hamurTipi[1])
            {
                label5.Text = "Turbo Hortumu";
                label6.Text = "25 cm";
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = false;

            }
            else if (textBox1.Text == macaKodu[2] && textBox2.Text == hamurTipi[2])
            {
                label5.Text = "Yakıt Depo Hortumu";
                label6.Text = "18 cm";
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = false;

            }
            else if (textBox1.Text == macaKodu[3] && textBox2.Text == hamurTipi[3])
            {
                label5.Text = "Radyatör Hortumu";
                label6.Text = "Sabit 50 cm";
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = false;

            }
            else if (textBox1.Text == macaKodu[4] && textBox2.Text == hamurTipi[4])
            {
                label5.Text = "Turbo Hortumu";
                label6.Text = "10 cm";
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = false;

            }
            else if (textBox1.Text == macaKodu[5] && textBox2.Text == hamurTipi[5])
            {
                label5.Text = "Turbo Hortumu";
                label6.Text = "20 cm";
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = false;

            }
            else if (textBox1.Text == macaKodu[6] && textBox2.Text == hamurTipi[6])
            {
                label5.Text = "Kalorifer Hortumu";
                label6.Text = "Sabit 50 cm";
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = false;

            }
            else if (textBox1.Text == macaKodu[7] && textBox2.Text == hamurTipi[7])
            {
                label5.Text = "Turbo Hortumu";
                label6.Text = "40 cm";
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = false;

            }
            else if (textBox1.Text == macaKodu[8] && textBox2.Text == hamurTipi[8])
            {
                label5.Text = "Radyatör Hortumu";
                label6.Text = "22 cm";
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = false;

            }
            else
            {
                label7.Visible = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear = true;
            while (clear) { 
                Temizle();
                break;
            }
        }
        public void Temizle()
        {
            textBox1.Clear();
            textBox2.Clear();
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 aa = new Form1();
            aa.Show();
            this.Hide();
            Temizle();
        }
    }
}
