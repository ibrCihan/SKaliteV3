using SKalite.Entity.General;

namespace SKalite.Entity.Document
{
    public class Document:BaseEntity
    {
        public string DocumentName { get; set; }
        public int DocumentCategoryId { get; set; }
        public int DocumentTypeId { get; set; }
    }
}
