namespace bai2;

public class Newspaper : Document
{
  public int PublishDay;

  public Newspaper() : base()
  {

  }

  public Newspaper(int DocId, string Publisher, int Quantity, int PublishDay) : base(DocId, Publisher, Quantity)
  {
    this.PublishDay = PublishDay;
  }

  public void setPublishDay(int PublishDay)
  {
    this.PublishDay = PublishDay;
  }

  public int getPublishDay()
  {
    return this.PublishDay;
  }

  public override object getDocumentInfomation()
  {
    return new {
      DocId = this.DocId,
      Publisher = this.Publisher,
      Quantity = this.Quantity,
      PublishDay = this.PublishDay
    };
  }
}