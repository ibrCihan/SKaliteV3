using SKalite.Entity.Document;

namespace SKalite.Service.Document
{
    public interface IDocumentCategoryService
    {
        DocumentCategory Create(DocumentCategory DocumentCategory);
        DocumentCategory Update(DocumentCategory DocumentCategory, int id);
        DocumentCategory Delete(int id);
        DocumentCategory GetById(int id);
        List<DocumentCategory> GetAll();
    }
}
