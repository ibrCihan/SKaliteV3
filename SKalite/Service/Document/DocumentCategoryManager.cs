using SKalite.Entity.Document;
using SKalite.Repositories;

namespace SKalite.Service.Document
{
    public class DocumentCategoryManager : IDocumentCategoryService
    {
        private readonly IGenericRepository<DocumentCategory> _repository;
        public DocumentCategoryManager(IGenericRepository<DocumentCategory> repository)
        {
            _repository = repository;
        }
        public DocumentCategory Create(DocumentCategory DocumentCategory)
        {
            return _repository.Add(DocumentCategory);
        }

        public DocumentCategory Delete(int id)
        {
            var delete = _repository.GetById(id);
            return _repository.Delete(delete);
        }

        public DocumentCategory Update(DocumentCategory DocumentCategory, int id)
        {
            return _repository.UpdateById(DocumentCategory, id);
        }

        public List<DocumentCategory> GetAll()
        {
            return _repository.GetAll();
        }

        public DocumentCategory GetById(int id)
        {
            return _repository.GetById(id);
        }
    }
}
