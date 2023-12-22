using checkpoint_v2_net_ita_2.Controllers;
using checkpoint_v2_net_ita_2.Repository.Context;
using checkpoint_v2_net_ita_2.Repository.Entities;

namespace checkpoint_v2_net_ita_2.Repository
{
    public class PlateRepository : IPlateRepository
    {
        private readonly IDbContext dbContext;

        public PlateRepository(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Add(Plate plate)
        {
            dbContext.Plates.Add(plate);
        }

        public List<Plate> GetPlates()
        {
            return dbContext.Plates;
        }
        public List<Plate> GetPlatesUnder10E()
        {
            return dbContext.Plates.Where(e => e.Price <= 10).ToList();
        }

        public List<Plate> GetByType(string type)
        {
            return dbContext.Plates.Where(e => e.Type == type).ToList();
        }

        public void Add(PlateController plate)
        {
            throw new NotImplementedException();
        }
    }
}
