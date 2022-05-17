using System;
using System.IO;
using System.Windows.Forms;

namespace notpanda
{
    public partial class Form1 : Form
    {
        String yol = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    
        private void kaydetToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //!String.IsNullOrWhiteSpace(yol)
            if (yol != null)
            {
                File.WriteAllText(yol, textBox1.Text);
                label2.Text = "Dosya başarıyla kaydedildi";
            }
            else
            {
                farklıKaydetToolStripMenuItem1_Click(sender, e);
                label2.Text = "Dosya başarıyla kaydedildi";
            }
            
        }

        private void farklıKaydetToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Metin dosyaları(*.txt)|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                File.WriteAllText(yol = saveFileDialog1.FileName, textBox1.Text);
                label2.Text = "Dosya başarıyla kaydedildi";
            }


        }

        private void açToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Metin dosyaları(*.txt)|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = File.ReadAllText(yol = openFileDialog1.FileName);
                string dosyaAdi;
                dosyaAdi = Path.GetFileName(yol);
                labelFormat.Text = ("Hedef dosya : "+ dosyaAdi);
                label2.Text = "Dosya başarıyla açıldı";

            }
        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
          
        }

        private void yapıştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void tümünüSeçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }
    
        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText = String.Empty;
        }

        private void geriAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sorun, cozum;
            sorun = textBox1.Text;
            textBox1.Text = cozum = sorun.Substring(0, sorun.Length - 1);
        }

        private void extdiolog()
        {
            DialogResult = MessageBox.Show("Mevcut dosyayı kaydetmek istiyor musunuz?",
                "Notepanda",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (yol == null)
            {
                extdiolog();

                if (DialogResult == DialogResult.Yes)
                {
                    kaydetToolStripMenuItem1_Click(sender, e);
                }
                else if (DialogResult == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            textBox1.Font = fontDialog1.Font;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void siyahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStrip1.BackColor = System.Drawing.Color.Black;
            menuStrip1.ForeColor = System.Drawing.Color.White;
            menuStrip2.BackColor = System.Drawing.Color.Black;
            menuStrip2.ForeColor = System.Drawing.Color.White;
            textBox1.ForeColor = System.Drawing.Color.White;
            textBox1.BackColor = System.Drawing.Color.Black;
            this.BackColor = System.Drawing.Color.Gray;

        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {   System.Drawing.Font eski = textBox1.Font;      
            textBox1.Font = new System.Drawing.Font(eski.FontFamily, eski.Size + 1, eski.Style);
        }

        private void aToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Drawing.Font eski = textBox1.Font;
            textBox1.Font = new System.Drawing.Font(eski.FontFamily, eski.Size - 1, eski.Style);
        }

        static int i = 0;
        private void bToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                textBox1.Font = new System.Drawing.Font(textBox1.Font, System.Drawing.FontStyle.Bold);
                bToolStripMenuItem.BackColor = System.Drawing.Color.DarkGray;
                bToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
                i= 1;
            }
            else
            {
                textBox1.Font = new System.Drawing.Font(textBox1.Font, System.Drawing.FontStyle.Regular);
                bToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
                bToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
                i = 0;
            }
            
            
            
        }

        private void renkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog renk = new ColorDialog();
            renk.ShowDialog();
           
            textBox1.ForeColor = renk.Color;
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains(textBox2.Text) == true)
            {
            textBox1.Select(textBox1.Text.IndexOf(textBox2.Text), textBox2.TextLength);
            textBox1.Focus();
            }
            else
            {
                MessageBox.Show("bulunamadı!");
            }
        }

        private void griToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            menuStrip2.BackColor = System.Drawing.Color.WhiteSmoke;
            textBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
        }

        private void yeşilToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            textBox1.ForeColor = System.Drawing.Color.Black;
            textBox1.BackColor = System.Drawing.Color.FromArgb(0, 255, 255);

        }
        static int l=0;
        private void ıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (l == 0)
            {
                textBox1.Font = new System.Drawing.Font(textBox1.Font, System.Drawing.FontStyle.Italic);
                l = 1;
            }
            else
            {
                textBox1.Font = new System.Drawing.Font(textBox1.Font, System.Drawing.FontStyle.Regular);
                l = 0;
            }
            
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {   
            if (checkBox1.Checked == true)
            {
                textBox1.Font = new System.Drawing.Font(textBox1.Font, System.Drawing.FontStyle.Underline);
                checkBox1.BackColor = System.Drawing.Color.DarkGray;
                checkBox1.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                textBox1.Font = new System.Drawing.Font(textBox1.Font, System.Drawing.FontStyle.Regular);
                checkBox1.BackColor = System.Drawing.Color.WhiteSmoke;            
                checkBox1.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void solaHizalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.TextAlign = HorizontalAlignment.Right;
        }

        private void sağaHizalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.TextAlign = HorizontalAlignment.Left;
        }

        private void ortalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.TextAlign = HorizontalAlignment.Center;
        }

        private void hakkındaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form hakkındaform = new Form2();
            hakkındaform.ShowDialog();
        }

        int Move;
        int Mouse_X;
        int Mouse_Y;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Move = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            Move = 0;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }
    }
}

