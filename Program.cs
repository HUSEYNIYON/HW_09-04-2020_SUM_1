using System;
namespace HM_09_04_2020_SUM_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    class DocumentWorker
    {
       public void OpenDocument()
        {
            Console.WriteLine("Document open");
        }
       public virtual void EditDocument()
        {
            Console.WriteLine("Document editing is available in version PRO");//Редактирование документа доступно в версии Пhj

        }
        public virtual void SaveDocument()
        {
            Console.WriteLine("Saving a document is available in version PRO");//Сохранение документа доступно в версии Про

        }
    }
    class ProDocumentWorker: DocumentWorker
    {
        public override void EditDocument()
        {

            Console.WriteLine("Document was edit!");

        }
        public override void SaveDocument()
        {
            Console.WriteLine("The document is saved in the old format, saving in other formats is available in the Expert version");
        }
    }
    class ExpertDocumentWorker:ProDocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine("The document is saved in a new format");//Документ сохранен в новом формате 
        }
    }
    }
}
