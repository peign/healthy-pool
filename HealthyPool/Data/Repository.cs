using SQLite;

namespace HealthyPool.Data
{
    public abstract class Repository<TTable> where TTable : Model, new()
    {
        protected SQLiteAsyncConnection _database;
        
        protected async Task Init()
        {
            if (_database is not null)
                return;

            _database = new SQLiteAsyncConnection(DbConstants.DatabasePath, DbConstants.Flags);
            var result = await _database.CreateTableAsync<TTable>();
        }

        public virtual async Task<List<TTable>> GetAsync()
        {
            await Init();
            return await _database.Table<TTable>().ToListAsync();
        }
        
        public virtual async Task<TTable> GetAsync(int id)
        {
            await Init();
            return await _database.Table<TTable>().FirstOrDefaultAsync(m => m.Id == id);
        }
        
        public virtual async Task<int> Save(TTable item)
        {
            await Init();
            if (item.Id != 0)
                return await _database.UpdateAsync(item);
            
            return await _database.InsertAsync(item);
        }
        
        public virtual async Task<int> Delete(TTable item)
        {
            await Init();
            return await _database.DeleteAsync(item);
        }
    }
}