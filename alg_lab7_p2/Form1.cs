using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alg_lab7_p2
{
    public partial class PictureViewProg : Form
    {
        public PictureViewProg()
        {
            InitializeComponent();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "jpg(*.jpg)|*.jpg|bmp(*.bmp)|*.bmp|png(*.png)|*.png|gif(*.gif)|*.gif";
            if (openFile.ShowDialog() == DialogResult.OK && openFile.FileName.Length > 0) {
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Image = Image.FromFile(openFile.FileName); 
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "jpg(*.jpg)|*.jpg|bmp(*.bmp)|*.bmp|png(*.png)|*.png|gif(*.gif)|*.gif";
            if (saveFile.ShowDialog() == DialogResult.OK && saveFile.FileName.Length > 0) {
                pictureBox1.Image.Save(saveFile.FileName);
            }
        }
    }
}
