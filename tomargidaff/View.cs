using OpenTK;
using System.Drawing;
using OpenTK.Graphics.OpenGL;

namespace tomargidaff
{
    public class View
    {
        public Vector2 position;

        // in radians, + = clockwise
        public double rotation;

        //1 = no zoom, 2 = 2x zoom
        public double zoom;

        public View(Vector2 startPosition, double startZoom = 1.0, double startRotation = 0.0)
        {
            this.position = startPosition;
            this.zoom = startZoom;
            this.rotation = startRotation;
        }

        public void Update()
        {
            
        }

        public void ApplyTransform()
        {
            Matrix4 transform = Matrix4.Identity;

            transform = Matrix4.Mult(transform, Matrix4.CreateTranslation(-position.X, -position.Y, 0));
            transform = Matrix4.Mult(transform, Matrix4.CreateRotationZ(-(float)rotation));
            transform = Matrix4.Mult(transform, Matrix4.CreateScale((float)zoom, (float)zoom, 1.0f));

            GL.MultMatrix(ref transform);
        }
    }
}