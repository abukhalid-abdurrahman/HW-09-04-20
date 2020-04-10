using System;

namespace  Task_1
{
    public class ProDocumentWorker : DocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт");
        }

        public override void EditDocument()
        {
            Console.WriteLine("Документ отредактирован");
        }
    }
}