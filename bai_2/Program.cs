// doc (id, publisher, quantity)
// - book (author, page)
// - magazine (publish number, publish month)
// - newspaper (publish day)

// use-case:
// - c a new doc
// - d a doc by id
// - retrive doc info
// - f a doc with type
// - exit

using bai2;

public class Program
{
  public static void Main(string[]args)
  {
    DocumentManagement documentManagement = new DocumentManagement();

    while (true)
    {
      System.Console.WriteLine("1: Add Document");
      System.Console.WriteLine("2: Delete Document");
      System.Console.WriteLine("3: Display Documents");
      System.Console.WriteLine("4: Search Documents");
      System.Console.WriteLine("5: Exit");

      int choice = Int32.Parse(Console.ReadLine()!);

      switch (choice)
      {
        case 5:
          break;
        case 1:
          System.Console.WriteLine("Choose type of document");
          System.Console.WriteLine("1: Book");
          System.Console.WriteLine("2: Magazine");
          System.Console.WriteLine("3: Newspaper");

          int ChoiceToCreateDoc = Int32.Parse(Console.ReadLine()!);

          System.Console.WriteLine("Publisher: ");
          string Publisher = Console.ReadLine()!;
          System.Console.WriteLine("Quantity: ");
          int Quantity = Int32.Parse(Console.ReadLine()!);

          switch (ChoiceToCreateDoc)
          {
            case 1:
            System.Console.WriteLine("Author: ");
            string Author = Console.ReadLine()!;
            System.Console.WriteLine("Page: ");
            int Page = Int32.Parse(Console.ReadLine()!);
            documentManagement.addDocument(new Book {
              DocId = new Random().Next(10),
              Author = Author,
              Publisher = Publisher,
              Quantity = Quantity,
              Page = Page
            });
            break;

            case 2:
            System.Console.WriteLine("PublishMonth: ");
            int PublishMonth = Int32.Parse(Console.ReadLine()!);
            System.Console.WriteLine("PublishNumber: ");
            int PublishNumber = Int32.Parse(Console.ReadLine()!);
            documentManagement.addDocument(new Magazine {
              DocId = new Random().Next(10),
              Publisher = Publisher,
              Quantity = Quantity,
              PublishMonth = PublishMonth,
              PublishNumber = PublishNumber
            });
            break;
            
            case 3:
            System.Console.WriteLine("PublishDay: ");
            int PublishDay = Int32.Parse(Console.ReadLine()!);
            documentManagement.addDocument(new Newspaper {
              DocId = new Random().Next(10),
              Publisher = Publisher,
              Quantity = Quantity,
              PublishDay = PublishDay
            });
            break;
          }
          documentManagement.getDocumentations();
        break;

        case 2:
          System.Console.WriteLine("ID to remove: ");
          int IdToDelete = Int32.Parse(Console.ReadLine()!);
          documentManagement.deleteDocumentById(IdToDelete);
        break;

        case 3:
          System.Console.WriteLine("Get documents");
          documentManagement.getDocumentations();
        break;

        case 4:
          System.Console.WriteLine("Search document");
          System.Console.WriteLine("Give a type: ");
          string type = Console.ReadLine()!;
          documentManagement.searchDocumentation(type);
        break;
      }
    }    
  }
}