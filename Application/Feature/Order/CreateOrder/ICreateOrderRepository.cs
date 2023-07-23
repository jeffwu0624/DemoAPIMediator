using WebApplication1.Dtos;

namespace WebApplication1.Application.Feature.Order.CreateOrder;

public interface ICreateOrderRepository
{
    Task CreateOrderAsync(OrderDto order);
}