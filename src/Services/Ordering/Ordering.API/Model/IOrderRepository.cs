using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace VillageFight.Services.Ordering.API.Model
{
    public interface IOrderRepository
    {
        Task<Order> GetOrderByIdAsync(Guid orderId);
        Task<Order> GetOrderByOrderNumberAsync(int orderNumber);
        Task<Order> AddOrGetOrderAsync(Order order);
        Task UpdateOrderAsync(Order order);
        Task<IEnumerable<OrderSummary>> GetOrdersFromBuyerAsync(string buyerId);
        Task<IEnumerable<CardType>> GetCardTypesAsync();
    }
}