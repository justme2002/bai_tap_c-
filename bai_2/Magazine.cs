namespace bai2;

public class Magazine : Document
{
  public int PublishNumber;
  public int PublishMonth;

  public Magazine() : base()
  {

  }

  public Magazine(int DocId, string Publisher, int Quantity, int PublishNumber, int PublishMonth) : base(DocId, Publisher, Quantity)
  {
    this.PublishMonth = PublishMonth;
    this.PublishNumber = PublishNumber;
  }

  public int getPublishNumber()
  {
    return this.PublishNumber;
  }

  public void setPublishNumber(int PublishNumber)
  {
    this.PublishNumber = PublishNumber;
  }

  public int getPublishMonth()
  {
    return this.PublishMonth;
  }

  public void setPublishMonth(int PublishMonth)
  {
    this.PublishMonth = PublishMonth;
  }

  public override object getDocumentInfomation()
  {
    return new {
      DocId = this.DocId,
      Publisher = this.Publisher,
      Quantity = this.Quantity,
      PublishMonth = this.PublishMonth,
      PublishNumber = this.PublishNumber
    };
  }
}