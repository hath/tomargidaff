namespace tomargidaff
{
    public struct Texture2D
    {
        private int id;
        private int width, height;

        public Texture2D(int id, int width, int height)
        {
            this.width = width;
            this.id = id;
            this.height = height;
        }

        public int ID
        {
            get { return id; }
        }

        public int Width
        {
            get { return width; }
        }

        public int Height
        {
            get { return height; }
        }

    }
}