using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalPhotoDiary
{
    public partial class Diary : Form
    {
        public Diary()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            openFD.InitialDirectory = "C:";
            openFD.Title = "Insert an Image";
            openFD.FileName = "";
            openFD.Filter = "JPEG Images|*.jpg|GIF Images|*.gif|Bitmaps|*.bmp";

            if (openFD.ShowDialog() == DialogResult.Cancel)
            {
                MessageBox.Show("Operartion Cancelled");

            }
            else
            {
                pictureBox1.Image = Bitmap.FromFile(openFD.FileName);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (eventNameTextBox.Text == "")
            {
                MessageBox.Show("Please Enter the event name");
            }

            else if (eventStoryTextBox.Text == "")
            {
                MessageBox.Show("Please Write your story");
            }

            else if (dateTimePicker1.Text == "")
            {
                MessageBox.Show("Select a Date");
            }

            else
            {
                ShowDiary showD = new ShowDiary(this);
                showD.Show();
                this.Hide();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
