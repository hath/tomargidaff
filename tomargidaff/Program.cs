using OpenTK;

namespace tomargidaff
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (Game window = new Game(640, 480))
            {
                window.Run();
            };
        }
    }
}