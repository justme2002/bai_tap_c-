namespace bai2;

public class DocumentManagement : IDocumentManagement
{
  public List<Document>? Documents { get; set; }
  
  
  public DocumentManagement()
  {
    this.Documents = new List<Document>
    {
      new Book() {
        DocId = 1234,
        Publisher = "Nha xuat ban kim dong",
        Quantity = 1000,
        Author = "Kim Lan",
        Page = 7
      },
      new Magazine() {
        DocId = 245674,
        Publisher = "Nha xuat ban thoi dai moi",
        Quantity = 1444,
        PublishMonth = 10,
        PublishNumber = 123423
      },
      new Newspaper() {
        DocId = 34536767,
        Publisher = "Nha xuat ban Ha Noi",
        Quantity = 200,
        PublishDay = 23
      }
    };
  }

  public void addDocument(Document document)
  {
    this.Documents!.Add(document);
  }

  public void deleteDocumentById(int Id)
  {
    Document document = this.Documents!.Find(d => d.DocId == Id)!;
    this.Documents.Remove(document);

    foreach (var item in this.Documents)
    {
      System.Console.WriteLine(item.getDocumentInfomation());
    }
  }

  public void getDocumentations()
  {
    foreach (var item in this.Documents!)
    {
      System.Console.WriteLine(item.getDocumentInfomation());
    }
  }

  public void searchDocumentation(string type)
  {
    if (type == "book")
    {
      var getBooks = this.Documents!.Where(d => d.GetType() == typeof(Book));
      foreach (var item in getBooks)
      {
        System.Console.WriteLine(item.getDocumentInfomation());
      }
    }

    if (type == "magazine")
    {
      var getMagazines = this.Documents!.Where(d => d.GetType() == typeof(Magazine));
      foreach (var item in getMagazines)
      {
        System.Console.WriteLine(item.getDocumentInfomation());
      }
    }

    if (type == "newspaper")
    {
      var getPapers = this.Documents!.Where(d => d.GetType() == typeof(Newspaper));
      foreach (var item in getPapers)
      {
        System.Console.WriteLine(item.getDocumentInfomation());
      }
    }
    
  }

  public void exitApp()
  {
    throw new NotImplementedException();
  }
}