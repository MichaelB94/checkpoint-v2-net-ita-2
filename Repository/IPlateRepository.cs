using checkpoint_v2_net_ita_2.Repository.Entities;
namespace checkpoint_v2_net_ita_2.Repository
{
    public interface IPlateRepository
    {
        public void Add(Plate plate);
        public List <Plate> GetPlates();

        public List<Plate> GetByType(string type);
        public List<Plate> GetPlatesUnder10E();

    }
}
