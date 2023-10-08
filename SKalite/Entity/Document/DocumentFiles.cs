using SKalite.Entity.General;

namespace SKalite.Entity.Document
{
    public class DocumentFiles:BaseEntity
    {
        public string FilePath { get; set; }
        public int DocumentId { get; set; }
    }
}
