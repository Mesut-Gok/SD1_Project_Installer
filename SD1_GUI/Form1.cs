using System;
using System.IO;
using Microsoft.VisualBasic;   // ← BU SATIR BURADA OLACAK
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SD1_GUI
{
    public partial class Form1 : Form
    {
        private string encryptionKey = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuFileOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open file";
            ofd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName;
                string content = File.ReadAllText(path);

                if (!string.IsNullOrEmpty(encryptionKey))
                {
                }
                textBoxContent.Text = content;
            }
        }

        private void menuFileSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Save file as";
            sfd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (sfd.ShowDialog() == DialogResult.OK)

            {
                string path = sfd.FileName;
                string content = textBoxContent.Text;

                if (!string.IsNullOrEmpty(encryptionKey))
                {
                }
                File.WriteAllText(path, content);
            }
        }

        private void menuOptionsSetKey_Click(object sender, EventArgs e)
        {
            string key = Interaction.InputBox("Enter key:", "Set Key", "");

            if (!string.IsNullOrEmpty(key))
            {
                encryptionKey = key;
                MessageBox.Show("Key set successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Key was not set.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void menuFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


