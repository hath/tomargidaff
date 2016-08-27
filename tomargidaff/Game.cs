using System;
using System.Drawing;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace tomargidaff
{
    class Game : GameWindow
    {
        private Texture2D _texture;
        private View _view;

        public Game(int width, int height)
            : base(width, height)
        {
            GL.Enable(EnableCap.Texture2D);
            _view = new View(Vector2.Zero, 2.0, MathHelper.PiOver4);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            _texture = ContentPipe.LoadTexture("tiles.jpg");
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);
            _view.position.Y += 0.01f;
            _view.Update();
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            base.OnRenderFrame(e);
            
            GL.Clear(ClearBufferMask.ColorBufferBit);
            GL.ClearColor(Color.CornflowerBlue);

            Spritebatch.Begin(this.Width, this.Height);
            _view.ApplyTransform();

            Spritebatch.Draw(_texture, Vector2.Zero, new Vector2(2f, 2f), Color.Green, new Vector2(10, 50));

            this.SwapBuffers();
        }
    }
}
