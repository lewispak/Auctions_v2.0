using Auctions_v2._0.Models;

namespace Auctions_v2._0.Data.Services
{
    public interface ICommentsService
    {
        Task Add(Comment comment);
    }
}
