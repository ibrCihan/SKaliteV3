using SKalite.Entity.Document;

namespace SKalite.Service.Document
{
    public interface IDocumentProcessService
    {
        DocumentProcess Create(DocumentProcess DocumentProcess);
        DocumentProcess Update(DocumentProcess DocumentProcess, int id);
        DocumentProcess Delete(int id);
        DocumentProcess GetById(int id);
        List<DocumentProcess> GetAll();
    }
}
