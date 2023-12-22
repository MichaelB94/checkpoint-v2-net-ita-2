using checkpoint_v2_net_ita_2.Repository.Entities;
namespace checkpoint_v2_net_ita_2.Repository.Context

{
    public interface IDbContext
    {
        public List<Plate> Plates { get; set; }
    }
}
