using WebApplication1.Dtos;

namespace WebApplication1.Application.Feature.Order.GetAllOrder;

public class OrderRepository : IOrderRepository
{
    public Task<List<OrderDto>> GetOrdersAsync()
    {
        return Task.FromResult(new List<OrderDto>()
        {
            new OrderDto(){ Id = 1, Name = "Order 1" },
            new OrderDto(){ Id = 2, Name = "Order 2" },
        });
    }
}