using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using SharpGL;

namespace TheGoodEditor2
{
    public partial class RenderForm : Form
    {
        public OpenGLControl glCont;
        OpenGL gl;

        public RenderForm()
        {
            InitializeComponent();

            gl = glCont.OpenGL;

            gl.ClearColor(0.125f, 0.1015f, 0.218f, 0);
        }

        private void InitGL(object sender, RenderEventArgs e)
        {
            
        }

        private void DrawCube(Vector3 position)
        {
            gl.Translate(position.X, position.Y, position.Z);
            gl.Begin(OpenGL.GL_QUADS);

            gl.Color(0.0f, 1.0f, 0.0f);
            gl.Vertex(1.0f, 1.0f, -1.0f);
            gl.Vertex(-1.0f, 1.0f, -1.0f);
            gl.Vertex(-1.0f, 1.0f, 1.0f);
            gl.Vertex(1.0f, 1.0f, 1.0f);

            // Bottom face (y = -1.0f)
            gl.Vertex(1.0f, -1.0f, 1.0f);
            gl.Vertex(-1.0f, -1.0f, 1.0f);
            gl.Vertex(-1.0f, -1.0f, -1.0f);
            gl.Vertex(1.0f, -1.0f, -1.0f);

            // Front face  (z = 1.0f)
            gl.Vertex(1.0f, 1.0f, 1.0f);
            gl.Vertex(-1.0f, 1.0f, 1.0f);
            gl.Vertex(-1.0f, -1.0f, 1.0f);
            gl.Vertex(1.0f, -1.0f, 1.0f);

            // Back face (z = -1.0f)
            gl.Vertex(1.0f, -1.0f, -1.0f);
            gl.Vertex(-1.0f, -1.0f, -1.0f);
            gl.Vertex(-1.0f, 1.0f, -1.0f);
            gl.Vertex(1.0f, 1.0f, -1.0f);

            // Left face (x = -1.0f)
            gl.Vertex(-1.0f, 1.0f, 1.0f);
            gl.Vertex(-1.0f, 1.0f, -1.0f);
            gl.Vertex(-1.0f, -1.0f, -1.0f);
            gl.Vertex(-1.0f, -1.0f, 1.0f);

            // Right face (x = 1.0f)
            gl.Vertex(1.0f, 1.0f, -1.0f);
            gl.Vertex(1.0f, 1.0f, 1.0f);
            gl.Vertex(1.0f, -1.0f, 1.0f);
            gl.Vertex(1.0f, -1.0f, -1.0f);

            gl.End();
        }

        private void OpenGLDraw(object sender, RenderEventArgs e)
        {
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
            gl.MatrixMode(OpenGL.GL_MODELVIEW);
            gl.LoadIdentity();

            foreach (var Object3D in MainWindow.objArr)
            {
                switch (Object3D.Class)
                {
                    case "SimpleObject":
                        DrawCube(Object3D.Pos);
                        break;
                    case "Platform":
                        DrawCube(Object3D.Pos);
                        break;
                    case "FloatingCollectible":
                        DrawCube(Object3D.Pos);
                        break;
                    default:
                        Console.WriteLine("Unknown Object Class\n");
                        break;
                }
            }
        }
        
    }
    public class Object
    {
        public Vector3 Pos;
        public Vector3 Rot;
        public Vector3 Scale;

        public string Name; // Just in case
        public string Class;

        public bool Visible = true;
    }

}
