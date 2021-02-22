namespace VillageFight.Services.Ordering.API.IntegrationEvents
{
    using VillageFight.BuildingBlocks.EventBus.Events;

    public class GracePeriodConfirmedIntegrationEvent : IntegrationEvent
    {
        public int OrderId { get; set; }

        public GracePeriodConfirmedIntegrationEvent()
        {
        }

        public GracePeriodConfirmedIntegrationEvent(int orderId) =>
            OrderId = orderId;
    }
}
