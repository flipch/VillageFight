using System.Threading.Tasks;

namespace VillageFight.Services.Ordering.API.Model
{
    public interface IEmailService
    {
        Task SendOrderConfirmation(Order order);
    }
}
