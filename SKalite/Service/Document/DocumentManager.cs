using SKalite.Entity.Document;
using SKalite.Repositories;

namespace SKalite
{
    public class DocumentManager : IDocumentService
    {
        private readonly IGenericRepository<Document> _repository;
        public DocumentManager(IGenericRepository<Document> repository)
        {
            _repository = repository;
        }
        public Document Create(Document Document)
        {
            return _repository.Add(Document);
        }

        public Document Delete(int id)
        {
            var delete = _repository.GetById(id);
            return _repository.Delete(delete);
        }

        public Document Update(Document Document, int id)
        {
            return _repository.UpdateById(Document, id);
        }

        public List<Document> GetAll()
        {
            return _repository.GetAll();
        }

        public Document GetById(int id)
        {
            return _repository.GetById(id);
        }
    }
}
