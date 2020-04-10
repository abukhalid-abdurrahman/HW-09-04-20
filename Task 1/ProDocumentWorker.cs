using System;

namespace  Task_1
{
    public class ProDocumentWorker : DocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт");
            base.SaveDocument();
        }

        public override void EditDocument()
        {
            Console.WriteLine("Документ отредактирован");
            base.EditDocument();
        }
    }
}