using SQLite;

namespace HealthyPool.Data
{
    public abstract class Model
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
    }
}