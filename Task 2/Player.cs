using System;

namespace Task_2
{
    public class Player : IPlayable, IRecodable
    {
        public void Play()
        {
            Console.WriteLine("Игра началась, запись рекорда начался!");
        }

        public void Pause()
        {
            Console.WriteLine("Игра приостановлена, запись рекорда приостановлен.");
        }

        public void Stop()
        {
            Console.WriteLine("Игра закончилась!");
        }

        public void Record()
        {
            Console.WriteLine("Запись рекорда остановлена!");
        }
    }
}
