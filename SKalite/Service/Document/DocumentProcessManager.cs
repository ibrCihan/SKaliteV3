using SKalite.Entity.Document;
using SKalite.Repositories;

namespace SKalite.Service.Document
{
    public class DocumentProcessManager : IDocumentProcessService
    {
        private readonly IGenericRepository<DocumentProcess> _repository;
        public DocumentProcessManager(IGenericRepository<DocumentProcess> repository)
        {
            _repository = repository;
        }
        public DocumentProcess Create(DocumentProcess DocumentProcess)
        {
            return _repository.Add(DocumentProcess);
        }

        public DocumentProcess Delete(int id)
        {
            var delete = _repository.GetById(id);
            return _repository.Delete(delete);
        }

        public DocumentProcess Update(DocumentProcess DocumentProcess, int id)
        {
            return _repository.UpdateById(DocumentProcess, id);
        }

        public List<DocumentProcess> GetAll()
        {
            return _repository.GetAll();
        }

        public DocumentProcess GetById(int id)
        {
            return _repository.GetById(id);
        }
    }
}
