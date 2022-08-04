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
    public partial class ShowDiary : Form

    {
        Diary diary;
        public ShowDiary(Diary diary)
        {
            InitializeComponent();
            this.diary = diary;
            this.label1.Text += " : " + this.diary.eventNameTextBox.Text;
            this.label3.Text += " : " + this.diary.dateTimePicker1.Text;
            this.label2.Text += " : " + this.diary.pictureBox1.Image;
            this.label4.Text += " : " + this.diary.eventStoryTextBox.Text;


        }

        private void ShowDiary_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
