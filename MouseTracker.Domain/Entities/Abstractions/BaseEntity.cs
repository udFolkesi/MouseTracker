using System.ComponentModel.DataAnnotations;

namespace MouseTracker.Domain.Entities.Abstractions
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
