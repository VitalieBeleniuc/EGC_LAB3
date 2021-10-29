using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;
using OpenTK.Platform;

namespace OpenTK_Test
{
    class Shapes
    {

        //Urmăriți comportamentului aplicație la desenarea următoarelor elemente:
        //• puncte;
        //• linii;
        //• linii folosind directiva LineLoop;
        //• linii, folosind directiva LineStrip;
        //• triunghiuri;
        //• triunghiuri, folosind directiva TriangleFan;
        //• triunghiuri, folosind directiva TriangleStrip;

        public void DrawPuncte()
        {
            GL.Begin(PrimitiveType.Points);
            GL.Color3(Color.Cyan);
            GL.Vertex2(0, 0);
            GL.End();
        }

        public void DrawAxe()
        {
            //Desenați axele de coordonate din aplicația-template folosind un singur apel GL.Begin().
            GL.Begin(PrimitiveType.Lines);
            //axa X
            GL.Color3(Color.Red);
            GL.Vertex2(-23.68, 0);
            GL.Vertex2(23.68, 0);
            //axa Y
            GL.Color3(Color.Red);
            GL.Vertex2(0, -23.68);
            GL.Vertex2(0, 23.68);
            GL.End();
        }

        public void DrawLinii()
        {
            GL.Begin(PrimitiveType.Lines);
            GL.Color3(Color.Red);
            GL.Vertex2(1, 3);
            GL.Vertex2(1, 6);
            GL.Vertex2(1, -3);
            GL.Vertex2(1, -6);
            GL.End();

        }


        public void DrawLineStrip()
        {
            GL.Begin(PrimitiveType.LineStrip);
            GL.Color3(Color.Purple);
            GL.Vertex2(-15, -10);
            GL.Color3(Color.Red);
            GL.Vertex2(-15, 12);
            GL.Color3(Color.Yellow);
            GL.Vertex2(15, 12);
            GL.Color3(Color.Green);
            GL.Vertex2(15, -10);

            GL.End();
        }

        public void DrawLineLoop()
        {
            GL.Begin(PrimitiveType.LineLoop);
            GL.Color3(Color.Yellow);
            GL.Vertex2(-10, -10);
            GL.Vertex2(-10, 10);

            GL.Vertex2(10, 10);
            GL.Vertex2(10, -10);

            GL.End();
        }


        public void DrawTriunghi()
        {
            GL.Begin(PrimitiveType.Triangles);
            GL.Color3(Color.Lime);
            GL.Vertex2(-5, 0);
            GL.Vertex2(-2, -5);
            GL.Vertex2(-2, 5);
            GL.End();
        }


        public void DrawTriunghiStrip()
        {
            GL.Begin(PrimitiveType.TriangleStrip);
            GL.Color3(Color.Lime);
            GL.Vertex2(-2, -7);
            GL.Vertex2(2, -7);
            GL.Vertex2(0, -9);
            GL.Color3(Color.Red);
            GL.Vertex2(9, -9);
            GL.End();
        }

        public void DrawTriunghiFan()
        {
            GL.Begin(PrimitiveType.TriangleFan);
            GL.Color3(Color.Lime);
            GL.Vertex2(5, 0);
            GL.Vertex2(2, -5);
            GL.Vertex2(2, 5);
            GL.Color3(Color.Red);
            GL.Vertex2(3, 6);
            GL.End();
        }

    }
}
