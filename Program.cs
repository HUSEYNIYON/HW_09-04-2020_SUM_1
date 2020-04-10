using System;
namespace HM_09_04_2020_SUM_1
{
    class Program
    {
        static void Main(string[] args)
        {
            DocumentWorker dw;
            Console.Write("Enter the key:");
            string key =Console.ReadLine();
            if (key=="pro")
                dw = new ProDocumentWorker();
            else if (key=="exp")
                dw = new ExpertDocumentWorker();
            else
                dw = new DocumentWorker();
            dw.OpenDocument();
            dw.SaveDocument();
            dw.EditDocument();
            Console.ReadKey();
        }
    class DocumentWorker
    {
        public void OpenDocument() => Console.WriteLine("Document open");
        public virtual void EditDocument() => Console.WriteLine("Document editing is available in version PRO");
        public virtual void SaveDocument() => Console.WriteLine("Saving a document is available in version PRO");
       
    }
    class ProDocumentWorker: DocumentWorker
    {
        public override void EditDocument() => Console.WriteLine("Document was edit!");
       
        public override void SaveDocument() => Console.WriteLine("The document is saved in the old format, saving in other formats is available in the Expert version");
    }
    class ExpertDocumentWorker:ProDocumentWorker
    {
        public override void SaveDocument() => Console.WriteLine("The document is saved in a new format");
    }
    }
}
