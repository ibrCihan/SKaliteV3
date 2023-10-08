using SKalite.Entity.Document;

namespace SKalite.Service.Document
{
    public interface IDocumentFilesService
    {
        DocumentFiles Create(DocumentFiles DocumentFiles);
        DocumentFiles Update(DocumentFiles DocumentFiles, int id);
        DocumentFiles Delete(int id);
        DocumentFiles GetById(int id);
        List<DocumentFiles> GetAll();
    }
}
