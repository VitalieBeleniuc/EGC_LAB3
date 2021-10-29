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



//Beleniuc Vitalie 3132B Laboratorul 3
//Aplicatie template scrisa de la 0


namespace OpenTK_Test
{

    class Window : GameWindow
    {
        Shapes shape = new Shapes();
        PreluareCoordonate data = new PreluareCoordonate();
        Desenare desen = new Desenare();
        Camera cam = new Camera();


        public Window() : base(900, 700, new GraphicsMode(32, 0, 0, 8))
        {
            VSync = VSyncMode.On;

            Console.WriteLine("Pentru a mari canalul RED pentru Vertexul 1: Z, micsora: X");
            Console.WriteLine("Pentru a mari canalul GREEN pentru Vertexul 1: C, micsora: V");
            Console.WriteLine("Pentru a mari canalul BLUE pentru Vertexul 1: B, micsora: N\n");

            Console.WriteLine("Pentru a mari canalul RED pentru Vertexul 2: A, micsora: S");
            Console.WriteLine("Pentru a mari canalul GREEN pentru Vertexul 2: D, micsora: F");
            Console.WriteLine("Pentru a mari canalul BLUE pentru Vertexul 2: G, micsora: H\n");

            Console.WriteLine("Pentru a mari canalul RED pentru Vertexul 3: Q, micsora: W");
            Console.WriteLine("Pentru a mari canalul GREEN pentru Vertexul 3: E, micsora: R");
            Console.WriteLine("Pentru a mari canalul BLUE pentru Vertexul 3: T, micsora: Y\n");

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            GL.ClearColor(Color.Blue);
            GL.Enable(EnableCap.DepthTest);
            GL.DepthFunc(DepthFunction.Less);
            GL.Hint(HintTarget.PolygonSmoothHint, HintMode.Nicest);
        }


        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            GL.Viewport(0, 0, Width, Height);

            double aspect_ratio = Width / (double)Height;



            Matrix4 perspective = Matrix4.CreatePerspectiveFieldOfView(MathHelper.PiOver4, (float)aspect_ratio, 1, 64);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref perspective);

            Matrix4 lookat = Matrix4.LookAt(0, 0, 30, 0, 0, 0, 0, 1, 0);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadMatrix(ref lookat);


        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            base.OnRenderFrame(e);
            List<int> poz = data.preluareCoordonate();


            GL.Clear(ClearBufferMask.ColorBufferBit);
            GL.Clear(ClearBufferMask.DepthBufferBit);

            shape.DrawAxe();
           
            GL.Begin(PrimitiveType.Triangles);
            GL.Color3(desen.colorRed_V1/255, desen.colorGreen_V1/255, desen.colorBlue_V1/255);
            GL.Vertex2(poz[0], poz[1]);
            GL.Color3(desen.colorRed_V2/255, desen.colorGreen_V2/255, desen.colorBlue_V2/255);
            GL.Vertex2(poz[2], poz[3]);
            GL.Color3(desen.colorRed_V3/255, desen.colorGreen_V3/255, desen.colorBlue_V3/255);
            GL.Vertex2(poz[4], poz[5]);
            GL.End();

            //shape.DrawPuncte();
            //GL.PointSize(20);
            //GL.LineWidth(5);

            //shape.DrawLinii();
            //shape.DrawLineStrip();
            //shape.DrawLineLoop();

            //shape.DrawTriunghi();
            //shape.DrawTriunghiStrip();
            //shape.DrawTriunghiFan();

            SwapBuffers();

        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);

            KeyboardState keyboard = Keyboard.GetState();
            MouseState mouse = Mouse.GetState();

            desen.deseneaza();
         
            if (keyboard[Key.Escape])
            {
                Exit();
            }
        }





        static void Main(string[] args)
        {
            using (Window example = new Window())
            {
                example.Run(30.0, 0.0);
            }
        }
    }
}