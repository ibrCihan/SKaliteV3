using SKalite.Entity.Document;
using SKalite.Repositories;

namespace SKalite.Service.Document
{
    public class DocumentTypeManager : IDocumentTypeService
    {
        private readonly IGenericRepository<DocumentType> _repository;
        public DocumentTypeManager(IGenericRepository<DocumentType> repository)
        {
            _repository = repository;
        }
        public DocumentType Create(DocumentType DocumentType)
        {
            return _repository.Add(DocumentType);
        }

        public DocumentType Delete(int id)
        {
            var delete = _repository.GetById(id);
            return _repository.Delete(delete);
        }

        public DocumentType Update(DocumentType DocumentType, int id)
        {
            return _repository.UpdateById(DocumentType, id);
        }

        public List<DocumentType> GetAll()
        {
            return _repository.GetAll();
        }

        public DocumentType GetById(int id)
        {
            return _repository.GetById(id);
        }
    }
}
