using SKalite.Entity.Document;

namespace SKalite.Service.Document
{
    public interface IDocumentTypeService
    {
        DocumentType Create(DocumentType DocumentType);
        DocumentType Update(DocumentType DocumentType, int id);
        DocumentType Delete(int id);
        DocumentType GetById(int id);
        List<DocumentType> GetAll();
    }
}
