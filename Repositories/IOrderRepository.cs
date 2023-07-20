using WebApplication1.Dtos;

namespace WebApplication1.Repositories;

public interface IOrderRepository
{
    Task<List<OrderDto>> GetOrdersAsync();
}

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