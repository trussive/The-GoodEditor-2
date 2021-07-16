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
    public partial class PlatformEditor : Form
    {
        public PlatformEditor()
        {
            InitializeComponent();
        }
        public static string SaveValueForTextPosXPlat = "";
        public static string SaveValueForTextPosYPlat = "";
        public static string SaveValueForTextPosZPlat = "";

        public static string SaveValueForTextRotXPlat = "";
        public static string SaveValueForTextRotYPlat = "";
        public static string SaveValueForTextRotZPlat = "";

        public static string SaveValueForTextScaleXPlat = "";
        public static string SaveValueForTextScaleYPlat = "";
        public static string SaveValueForTextScaleZPlat = "";
        private void PlatformEditor_Load(object sender, EventArgs e)
        {
            txtPosX.Text = MainWindow.SetValueForTextPlatformPosX;
            txtPosY.Text = MainWindow.SetValueForTextPlatformPosY;
            txtPosZ.Text = MainWindow.SetValueForTextPlatformPosZ;

            txtRotX.Text = MainWindow.SetValueForTextPlatformRotX;
            txtRotY.Text = MainWindow.SetValueForTextPlatformRotY;
            txtRotZ.Text = MainWindow.SetValueForTextPlatformRotZ;

            txtScaleX.Text = MainWindow.SetValueForTextPlatformScaleX;
            txtScaleY.Text = MainWindow.SetValueForTextPlatformScaleY;
            txtScaleZ.Text = MainWindow.SetValueForTextPlatformScaleZ;
        }

        private void btnApplyScaleX_Click(object sender, EventArgs e)
        {
            string input1 = txtScaleX.Text;

            txtScaleY.Text = input1;
            txtScaleZ.Text = input1;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void PlatformEditor_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void saveDataEdited_Click(object sender, EventArgs e)
        {
            SaveValueForTextPosXPlat = txtPosX.Text;
            SaveValueForTextPosYPlat = txtPosY.Text;
            SaveValueForTextPosZPlat = txtPosZ.Text;

            SaveValueForTextRotXPlat = txtRotX.Text;
            SaveValueForTextRotYPlat = txtRotY.Text;
            SaveValueForTextRotZPlat = txtRotZ.Text;

            SaveValueForTextScaleXPlat = txtScaleX.Text;
            SaveValueForTextScaleYPlat = txtScaleY.Text;
            SaveValueForTextScaleZPlat = txtScaleZ.Text;
            MainWindow form = Application.OpenForms.OfType<MainWindow>().FirstOrDefault();
            if (form != null)
            {
                form.savePlatform(sender, e);
            }
        }
    }
}
