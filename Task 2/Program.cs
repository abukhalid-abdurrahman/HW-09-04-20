using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            player.Play();
            player.Pause();
            player.Record();
            player.Stop();
        }
    }
}
