using System;

namespace Task_1
{
    class Program
    {
        private void Use()
        {
            string menuInfo = "A - Создание документа\nB - Редактирование документа\nC - Открытие документа\nВыход - Для выхода из программы.";
            Console.WriteLine(menuInfo);
            string cmd = string.Empty;
            while(cmd != "Выход")
            {
                Console.Write("Ввод: ");
                cmd = Console.ReadLine();
                
            }
        }
        private static void Register(string key)
        {
            switch(key)
            {
                case "free":
                break;
                case "pro":
                break;
                case "exp":
                break;
                default:
                    Console.WriteLine($"Регистрация ключа {key} не доступна!");
                break;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ключ доступа.\nПропустите этот этап в случае отказа от расширенной версии,\nи хотите использовать бесплатную версию.");
            Console.Write("Введите ключ: ");
            string key = Console.ReadLine();
            if(key != null)
            {
                Register(key);
            }
            else
            {
                Register("free");
                Console.WriteLine("У вас открылся доступ к бесплатной версии.");
            }
        }
    }
}
