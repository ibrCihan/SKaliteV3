using SKalite.Entity.Document;
using SKalite.Repositories;

namespace SKalite.Service.Document
{
    public class DocumentFilesManager : IDocumentFilesService
    {
        private readonly IGenericRepository<DocumentFiles> _repository;
        public DocumentFilesManager(IGenericRepository<DocumentFiles> repository)
        {
            _repository = repository;
        }
        public DocumentFiles Create(DocumentFiles DocumentFiles)
        {
            return _repository.Add(DocumentFiles);
        }

        public DocumentFiles Delete(int id)
        {
            var delete = _repository.GetById(id);
            return _repository.Delete(delete);
        }

        public DocumentFiles Update(DocumentFiles DocumentFiles, int id)
        {
            return _repository.UpdateById(DocumentFiles, id);
        }

        public List<DocumentFiles> GetAll()
        {
            return _repository.GetAll();
        }

        public DocumentFiles GetById(int id)
        {
            return _repository.GetById(id);
        }
    }
}
