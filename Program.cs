using System;

namespace CatRunner
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new CatRunnerGame())
                game.Run();
        }
    }
}
