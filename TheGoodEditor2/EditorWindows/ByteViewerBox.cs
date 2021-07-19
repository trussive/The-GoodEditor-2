using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheGoodEditor2.EditorWindows;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Be.Windows.Forms;
using System.Globalization;
using System.IO;

namespace TheGoodEditor2.EditorWindows
{
    public partial class ByteViewerBox : Form
    {

        public ByteViewerBox()
        {
            InitializeComponent();
        }
        public static string SaveHexData = "";
        private void noteTakerOpen_Click(object sender, EventArgs e)
        {
            NoteTaker takeNotes = new NoteTaker();
            takeNotes.Show();
        }

        private void ByteViewerBox_Load(object sender, EventArgs e)
        {
            byte[] byteViewerBytes = MainWindow.x;
            hexViewerBox.ByteProvider = new DynamicByteProvider(byteViewerBytes);
        }
        private void btnSaveData_Click(object sender, EventArgs e)
        {
            hexViewerBox.SelectAll();
            hexViewerBox.CopyHex();
            hexViewerBox.SelectionLength = 0;
            MainWindow form = Application.OpenForms.OfType<MainWindow>().FirstOrDefault();
            if (form != null)
            {
                form.HexBox_CopiedHex(sender, e);
            }
        }
    }
}
