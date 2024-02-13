namespace WebApplication2.Views.Contexts.Entities
{
    public class Size
    {
       public int Id { get; set; }
       public string Name { get; set; }

       public string SmallName { get; set; }
       public DateTime  CreatedAt { get; set; }

       public int? CreatedBy { get; set; }

        public DateTime LastModifiedAt { get; set; }

        public int? LastModifiedBy { get; set; }

        public DateTime DeletedAt { get; set; }

        public int? DeletedBy { get; set; }
    }
}
