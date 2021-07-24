﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using SharpGL;
using HiHoFile;


namespace TheGoodEditor2 
{
    

    public class Renderer 
    {
        OpenGL gl;

        public Renderer()
        {
            gl = new OpenGL();
            Init();
        }
        
        public void Init()
        {
            float r = 32 / 255;
            float g = 26 / 255;
            float b = 56 / 255;
            gl.ClearColor(r, g, b, 0);
        }

        public void Update()
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

        public void OpenGLDraw()
        {
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
            gl.MatrixMode(OpenGL.GL_MODELVIEW);
            gl.LoadIdentity();

            foreach(var Object3D in MainWindow.objArr)
            {
                switch(Object3D.Class)
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
}
