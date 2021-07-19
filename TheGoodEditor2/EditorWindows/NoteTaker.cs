using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace TheGoodEditor2.EditorWindows
{
    public partial class NoteTaker : Form
    {
        public NoteTaker()
        {
            InitializeComponent();
        }

        private void saveTakenNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = "*.txt";
            sfd.Filter = "Text files|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, rtfNotes.Text);
            }
        }

        private void closeTheNoteTakerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openSavedNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                rtfNotes.Text = File.ReadAllText(ofd.FileName);
            }
        }
    }
}
