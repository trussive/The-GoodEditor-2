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
    public partial class FloatingCollectibleEditorWindow : Form
    {
        public FloatingCollectibleEditorWindow()
        {
            InitializeComponent();
        }
        public static string SaveValueForTextPosXCollectible = "";
        public static string SaveValueForTextPosYCollectible = "";
        public static string SaveValueForTextPosZCollectible = "";
        private void FloatingCollectibleEditorWindow_Load(object sender, EventArgs e)
        {
            txtPosX.Text = MainWindow.SetValueForCollectiblePosX;
            txtPosY.Text = MainWindow.SetValueForCollectiblePosY;
            txtPosZ.Text = MainWindow.SetValueForCollectiblePosZ;
        }

        private void saveDataEdited_Click(object sender, EventArgs e)
        {
            SaveValueForTextPosXCollectible = txtPosX.Text;
            SaveValueForTextPosYCollectible = txtPosY.Text;
            SaveValueForTextPosZCollectible = txtPosZ.Text;

            MainWindow form = Application.OpenForms.OfType<MainWindow>().FirstOrDefault();
            if (form != null)
            {
                form.saveFloatingCollectible(sender, e);
            }
        }
    }
}
