using SKalite.Entity.Document;

namespace SKalite
{
    public interface IDocumentService
    {
        Document Create(Document Document);
        Document Update(Document Document, int id);
        Document Delete(int id);
        Document GetById(int id);
        List<Document> GetAll();
    }
}
