using VillageFight.BuildingBlocks.EventBus.Events;
using System.Threading.Tasks;

namespace VillageFight.BuildingBlocks.EventBus.Abstractions
{
    public interface IEventBus
    {
        Task PublishAsync<TIntegrationEvent>(TIntegrationEvent @event)
            where TIntegrationEvent : IntegrationEvent;
    }
}
