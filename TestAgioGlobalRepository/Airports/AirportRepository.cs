namespace TestAgioGlobalRepository.Airports
{
    using TestAgioGlobalModel;
    using TestAgioGlobalModel.Entities;
    using System.Linq;

    public class AirportRepository : IAirportRepository
    {
        private readonly ModelContext _dbContext;

        public AirportRepository(ModelContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<Airports> GetAll()
        {
            return _dbContext?.Airports;
        }
    }
}
