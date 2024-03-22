using Auctions_v2._0.Models;

namespace Auctions_v2._0.Data.Services
{
    public interface IListingsService
    {
        IQueryable<Listing> GetAll();
        Task Add(Listing listing);
    }
}
