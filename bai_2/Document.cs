using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;

namespace bai2;

public abstract class Document
{
  public int DocId { get; set; }
  public string? Publisher { get; set; }
  public int Quantity { get; set; }

  public Document()
  {

  }

  public Document(int DocId, string Publisher, int Quantity)
  {
    this.DocId = DocId;
    this.Publisher = Publisher;
    this.Quantity = Quantity;
  }

  public abstract object getDocumentInfomation();
}