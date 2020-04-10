using System;

namespace Task_1
{
    class Program
    {
        private static void Use(DocumentWorker dw)
        {
            string menuInfo = "A - Сохранение документа\nB - Редактирование документа\nC - Открытие документа\nВыход - Для выхода из программы.";
            Console.WriteLine(menuInfo);
            string cmd = string.Empty;
            while(cmd != "Выход")
            {
                Console.Write("Ввод: ");
                cmd = Console.ReadLine();
                if(cmd.Equals("A"))
                {
                    dw.SaveDocument();
                }
                else if (cmd.Equals("B"))
                {
                    dw.EditDocument();
                }
                else if(cmd.Equals("C"))
                {
                    dw.OpenDocument();
                }
                else
                    break;
            }
        }
        private static void Register(string key)
        {
            switch(key)
            {
                case "free":
                DocumentWorker dw = new DocumentWorker();
                Use(dw);
                break;
                case "pro":
                ProDocumentWorker pdw = new ProDocumentWorker();
                Use(pdw);
                break;
                case "exp":
                ExpertDocumentWorker edw = new ExpertDocumentWorker();
                Use(edw);
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
            if(key != "")
            {
                Register(key);
            }
            else
            {
                Console.WriteLine("У вас открылся доступ к бесплатной версии.");
                Register("free");
            }
        }
    }
}
