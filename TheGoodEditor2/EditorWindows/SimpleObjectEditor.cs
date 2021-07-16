using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheGoodEditor2.EditorWindows
{
    public partial class SimpleObjectEditor : Form
    {
        public SimpleObjectEditor()
        {
            InitializeComponent();
        }

        public static string SaveValueForTextPosX = "";
        public static string SaveValueForTextPosY = "";
        public static string SaveValueForTextPosZ = "";

        public static string SaveValueForTextRotX = "";
        public static string SaveValueForTextRotY = "";
        public static string SaveValueForTextRotZ = "";

        public static string SaveValueForTextScaleX = "";
        public static string SaveValueForTextScaleY = "";
        public static string SaveValueForTextScaleZ = "";

        public static string SaveVisibilityFlag = "";
        public static string SaveCollFlag = "";
        private void button3_Click(object sender, EventArgs e)
        {
            txtPosX.Text = String.Empty;
            txtPosY.Text = String.Empty;
            txtPosZ.Text = String.Empty;
            txtRotX.Text = String.Empty;
            txtRotY.Text = String.Empty;
            txtRotZ.Text = String.Empty;
            txtScaleX.Text = String.Empty;
            txtScaleY.Text = String.Empty;
            txtScaleZ.Text = String.Empty;
        }

        private void btnApplyScaleX_Click(object sender, EventArgs e)
        {
            string input1 = txtScaleX.Text;

            txtScaleY.Text = input1;
            txtScaleZ.Text = input1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Generate Random Numbers for the Position Fields
            Random slumpGenerator1 = new Random();
            int txt = slumpGenerator1.Next(0, 100);
            Random slumpGenerator2 = new Random();
            int txt1 = slumpGenerator2.Next(0, 50);
            Random slumpGenerator3 = new Random();
            int txt2 = slumpGenerator3.Next(0, 90);
            txtPosX.Text = txt.ToString();
            txtPosY.Text = txt1.ToString();
            txtPosZ.Text = txt2.ToString();

            // Generate Random Numbers for the Rotation Fields
            Random slumpGenerator4 = new Random();
            int txt4 = slumpGenerator4.Next(0, 100);
            Random slumpGenerator5 = new Random();
            int txt5 = slumpGenerator5.Next(0, 50);
            Random slumpGenerator6 = new Random();
            int txt6 = slumpGenerator6.Next(0, 90);
            txtRotX.Text = txt4.ToString();
            txtRotY.Text = txt5.ToString();
            txtRotZ.Text = txt6.ToString();

            // Generate Random Numbers for the Scale Fields
            Random slumpGenerator7 = new Random();
            int txt7 = slumpGenerator7.Next(0, 100);
            Random slumpGenerator8 = new Random();
            int txt8 = slumpGenerator8.Next(-100, 89);
            Random slumpGenerator9 = new Random();
            int txt9 = slumpGenerator9.Next(0, 53);
            txtScaleX.Text = txt7.ToString();
            txtScaleY.Text = txt8.ToString();
            txtScaleZ.Text = txt9.ToString();
        }

        private void SimpleObjectEditor_Load(object sender, EventArgs e)
        {
            txtPosX.Text = MainWindow.SetValueForTextPosX;
            txtPosY.Text = MainWindow.SetValueForTextPosY;
            txtPosZ.Text = MainWindow.SetValueForTextPosZ;

            txtRotX.Text = MainWindow.SetValueForTextRotX;
            txtRotY.Text = MainWindow.SetValueForTextRotY;
            txtRotZ.Text = MainWindow.SetValueForTextRotZ;

            txtScaleX.Text = MainWindow.SetValueForTextScaleX;
            txtScaleY.Text = MainWindow.SetValueForTextScaleY;
            txtScaleZ.Text = MainWindow.SetValueForTextScaleZ;

            txtFlag.Text = MainWindow.SetFlagVisibility;
            txtCollFlag.Text = MainWindow.setCollFlag;
        }

        private void saveDataEdited_Click(object sender, EventArgs e)
        {

        }

        private void SimpleObjectEditor_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveValueForTextPosX = txtPosX.Text;
            SaveValueForTextPosY = txtPosY.Text;
            SaveValueForTextPosZ = txtPosZ.Text;

            SaveValueForTextRotX = txtRotX.Text;
            SaveValueForTextRotY = txtRotY.Text;
            SaveValueForTextRotZ = txtRotZ.Text;

            SaveValueForTextScaleX = txtScaleX.Text;
            SaveValueForTextScaleY = txtScaleY.Text;
            SaveValueForTextScaleZ = txtScaleZ.Text;

            SaveVisibilityFlag = txtFlag.Text;
            SaveCollFlag = txtCollFlag.Text;
        }
    }
}
