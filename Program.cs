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
    }
}
