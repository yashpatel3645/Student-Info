using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Student_Info
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult rs = openFileDialog1.ShowDialog();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog2.Filter = "Image File(*.jpg;*.png;*.jpeg;*.gif;*.bmp)|*.jpg;*.png;*.jpeg;*.gif;*.bmp";
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog2.FileName);
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You Want To Exit?", "Exit", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (fname.Text == "")
            {
                MessageBox.Show("Please Fill First Name Properly");
            }
            if (mname.Text == "")
            {
                MessageBox.Show("Please Fill Middle Name Properly");
            }
            if (lname.Text == "")
            {
                MessageBox.Show("Please Fill Last Name Properly");
            }
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Please Select Your Branch");
            }
            if (comboBox2.Text == "")
            {
                MessageBox.Show("Please Select Your Semester");
            }
            if (cpi.Text == "")
            {
                MessageBox.Show("Please Fill CPI Properly");
            }
            if (spi.Text == "")
            {
                MessageBox.Show("Please Fill SPI Properly");
            } if (con.Text == "")
            {
                MessageBox.Show("Please Fill Contect Properly");
            }
            if (add.Text == "")
            {
                MessageBox.Show("Please Fill Address Properly");
            }
            if (con.Text.Length < 10)
            {
                MessageBox.Show("Please Enter Contect Number Properly");
            }
            if (eno.TextLength < 12)
            {
                MessageBox.Show("Enter 12 digit Enrollment Number");
            }
            try { 
            FileStream F = new FileStream(eno.Text+".txt", FileMode.CreateNew, FileAccess.Write, FileShare.None);
            StreamWriter s = new StreamWriter(F);
            String detail = fname.Text +"\n "+ mname.Text + "\n " + lname.Text + "\n " + eno.Text + "\n " + comboBox1.SelectedItem.ToString()
                + "\n " + comboBox2.SelectedItem.ToString() + "\n " + cpi.Text + "\n " + spi.Text + "\n "+label12.Text+"\n "
                + con.Text + "\n " + add.Text;
            s.WriteAsync(detail);
            s.Close();
            F.Close();
            reset();
                }
            catch(Exception ep)
            {
                MessageBox.Show(ep.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label12.Text = Convert.ToString((Convert.ToDouble(cpi.Text) - 0.5) * 10); 
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reset();
        }
        void reset()
        {
            fname.Text = null;
            mname.Text = null;
            lname.Text = null;
            eno.Text = null;
            comboBox1.Text = null;
            comboBox2.Text = null;
            cpi.Text = null;
            spi.Text = null;
            label12.Text = null;
            con.Text = null;
            add.Text = null;
            pictureBox1.Image = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            fname.Text = "YASH";
            mname.Text = "MANUBHAI";
            lname.Text = "PATEL";
            eno.Text = "151280107042";
            comboBox1.SelectedIndex = 1;
            comboBox2.SelectedIndex = 6;
            cpi.Text = "8";
            spi.Text = "9";
            con.Text = "9924091719";
            add.Text = "1,hat";
        }
    }
}