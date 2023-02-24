using SQLite;

namespace HealthyPool.Data.Models
{
    [Table("pools")]
    public class Pool : Model
    {   
        [MaxLength(100), Unique]
        public string Name { get; set; }
    }
}