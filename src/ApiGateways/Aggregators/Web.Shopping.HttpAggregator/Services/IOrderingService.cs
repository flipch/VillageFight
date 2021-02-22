using VillageFight.Web.Shopping.HttpAggregator.Models;
using System.Threading.Tasks;

namespace VillageFight.Web.Shopping.HttpAggregator.Services
{
    public interface IOrderingService
    {
        Task<OrderData> GetOrderDraftAsync(BasketData basketData);
    }
}