using WebApplication1.Dtos;
using WebApplication1.Repositories;

namespace WebApplication1.Application.Feature.Order.CreateOrder;

public class CreateOrderRepository : ICreateOrderRepository
{
    public Task CreateOrderAsync(OrderDto order)
    {
        MockOrderRepository.AddOrder(order);
        return Task.CompletedTask;
    }
}