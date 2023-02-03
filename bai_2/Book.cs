namespace bai2;

public class Book : Document
{
  public string? Author;
  public int Page;

  public Book() : base()
  {

  } 

  public Book(int DocId, string Publisher, int Quantity, string Author, int Page) : base(DocId, Publisher, Quantity)
  {
    this.Author = Author;
    this.Page = Page;
  }

  public string getAuthor()
  {
    return this.Author!;
  }

  public void setAuthor(string Author)
  {
    this.Author = Author;
  }

  // public int getMonth()
  // {
  //   return this.Page;
  // }

  // public void getMonth(int Month)
  // {
  //   this.Month = Month;
  // }

  public override object getDocumentInfomation()
  {
    return new {
      DocId = this.DocId,
      Publisher = this.Publisher,
      Quantity = this.Quantity,
      Author = this.Author,
      Month = this.Page
    };
  }
}