using HealthyPool.Data.Models;
using HealthyPool.Data.Repositories;

namespace HealthyPool.ViewModels
{
    public class MainPageViewModel
    {
        private readonly PoolRepository _poolRepo;
        
        

        public MainPageViewModel(PoolRepository poolRepo)
        {
            _poolRepo = poolRepo;
            initPools();
        }

        public List<Pool> Pools { get; } = new List<Pool>();


        private void initPools()
        {
            Pools.Add(new Pool()
            {
                Id = 1,
                Name = "Pool 1"
            });
            Pools.Add(new Pool()
            {
                Id = 2,
                Name = "Pool 2"
            });
            Pools.Add(new Pool()
            {
                Id = 3,
                Name = "Pool 3"
            });
        }
    }
}