using Auctions_v2._0.Models;

namespace Auctions_v2._0.Data.Services
{
    public interface IBidsService
    {
        Task Add(Bid bid);

        IQueryable<Bid> GetAll();
    }
}
