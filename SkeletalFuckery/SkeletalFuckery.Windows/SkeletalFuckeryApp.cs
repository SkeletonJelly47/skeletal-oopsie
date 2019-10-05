using Xenko.Engine;

namespace SkeletalFuckery
{
    class SkeletalFuckeryApp
    {
        static void Main(string[] args)
        {
            using (var game = new Game())
            {
                game.Run();
            }
        }
    }
}
