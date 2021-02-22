using System.Threading.Tasks;
using VillageFight.Web.Shopping.HttpAggregator.Models;

namespace VillageFight.Web.Shopping.HttpAggregator.Services
{
    public interface IBasketService
    {
        Task<BasketData> GetById(string id, string accessToken);

        Task UpdateAsync(BasketData currentBasket, string accessToken);
    }
}
