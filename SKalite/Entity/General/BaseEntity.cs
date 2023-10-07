namespace SKalite.Entity.General
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedUserId { get; set; }
        public int CreatedUserId { get; set; }
        public int IsActive { get; set; } = 1; // 0 Pasif - 1 Aktif
    }
}
