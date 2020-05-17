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
using System.Diagnostics;

namespace alg_lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_goto_Click(object sender, EventArgs e)
        {
            itemslistBox.Items.Clear();
            DirectoryInfo dir = new DirectoryInfo(dirPath.Text);
            DirectoryInfo[] dirs = dir.GetDirectories();
            foreach (DirectoryInfo d in dirs) {
                itemslistBox.Items.Add(d);
            }
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo f in files)
            {
                itemslistBox.Items.Add(f);
            }
        }

        private void images_listBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (Path.GetExtension(Path.Combine(dirPath.Text, itemslistBox.SelectedItem.ToString())) == "")
            {
                dirPath.Text = Path.Combine(dirPath.Text, itemslistBox.SelectedItem.ToString());
                itemslistBox.Items.Clear();
                DirectoryInfo dir = new DirectoryInfo(dirPath.Text);
                DirectoryInfo[] dirs = dir.GetDirectories();
                foreach (DirectoryInfo d in dirs)
                {
                    itemslistBox.Items.Add(d);
                }
                FileInfo[] files = dir.GetFiles();
                foreach (FileInfo f in files)
                {
                    itemslistBox.Items.Add(f);
                }
            }
            else {
                Process.Start(Path.Combine(dirPath.Text, itemslistBox.SelectedItem.ToString()));
            }
            /*dirPath.Text = Path.Combine(dirPath.Text, images_listBox.SelectedItem.ToString());
            images_listBox.Items.Clear();
            DirectoryInfo dir = new DirectoryInfo(dirPath.Text);
            DirectoryInfo[] dirs = dir.GetDirectories();
            foreach (DirectoryInfo d in dirs)
            {
                images_listBox.Items.Add(d);
            }
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo f in files)
            {
                images_listBox.Items.Add(f);
            }*/
        }

        private void btn_goBack_Click(object sender, EventArgs e)
        {
            if (dirPath.Text[dirPath.Text.Length - 1] == '\\')
            {
                dirPath.Text = dirPath.Text.Remove(dirPath.Text.Length - 1, 1);
                while (dirPath.Text[dirPath.Text.Length - 1] == '\\')
                {
                    dirPath.Text = dirPath.Text.Remove(dirPath.Text.Length - 1, 1);
                }
            }
            else if (dirPath.Text[dirPath.Text.Length - 1] != '\\')
            {
                while (dirPath.Text[dirPath.Text.Length - 1] != '\\')
                {
                    dirPath.Text = dirPath.Text.Remove(dirPath.Text.Length - 1, 1);
                }
            }
            else {
                while (dirPath.Text[dirPath.Text.Length - 1] != '\\')
                {
                    dirPath.Text = dirPath.Text.Remove(dirPath.Text.Length - 1, 1);
                }
            }
        }
    }
}
