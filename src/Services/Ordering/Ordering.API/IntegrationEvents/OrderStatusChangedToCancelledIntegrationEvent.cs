﻿using System;
using VillageFight.BuildingBlocks.EventBus.Events;

namespace VillageFight.Services.Ordering.API.IntegrationEvents
{
    public class OrderStatusChangedToCancelledIntegrationEvent : IntegrationEvent
    {
        public Guid OrderId { get; set; }
        public string OrderStatus { get; set; }
        public string Description { get; set; }
        public string BuyerName { get; set; }

        public OrderStatusChangedToCancelledIntegrationEvent()
        {
        }

        public OrderStatusChangedToCancelledIntegrationEvent(Guid orderId, string orderStatus,
            string description, string buyerName)
        {
            OrderId = orderId;
            OrderStatus = orderStatus;
            Description = description;
            BuyerName = buyerName;
        }
    }
}
