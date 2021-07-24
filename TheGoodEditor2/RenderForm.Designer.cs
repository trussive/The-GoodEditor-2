
namespace TheGoodEditor2
{
    partial class RenderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.glCont = new SharpGL.OpenGLControl();
            ((System.ComponentModel.ISupportInitialize)(this.glCont)).BeginInit();
            this.SuspendLayout();
            // 
            // glCont
            // 
            this.glCont.DrawFPS = false;
            this.glCont.Location = new System.Drawing.Point(0, 0);
            this.glCont.Name = "glCont";
            this.glCont.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL1_5;
            this.glCont.RenderContextType = SharpGL.RenderContextType.DIBSection;
            this.glCont.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            this.glCont.Size = new System.Drawing.Size(801, 453);
            this.glCont.TabIndex = 0;
            this.glCont.OpenGLDraw += new SharpGL.RenderEventHandler(this.OpenGLDraw);
            // 
            // RenderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.glCont);
            this.Name = "RenderForm";
            this.Text = "RenderForm";
            ((System.ComponentModel.ISupportInitialize)(this.glCont)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}