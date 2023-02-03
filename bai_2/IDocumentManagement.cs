namespace bai2;

public interface IDocumentManagement
{
  public void addDocument(Document document);
  public void deleteDocumentById(int Id);
  public void getDocumentations();
  public void searchDocumentation(string typeOfDocument);
  public void exitApp();
}