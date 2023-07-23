using WebApplication1.Dtos;

namespace WebApplication1.Application.Feature.Order.GetOrderById;

public class GetOrderByIoRepository : IGetOrderByIdRepository
{
    private readonly List<OrderDto> _orders = new List<OrderDto>()
    {
        new OrderDto() { Id = 1, Name = "Order 1" },
        new OrderDto() { Id = 2, Name = "Order 2" },
        new OrderDto() { Id = 3, Name = "Order 3" },
        new OrderDto() { Id = 4, Name = "Order 4" },
        new OrderDto() { Id = 5, Name = "Order 5" },
    };
    
    public Task<OrderDto> findByIdAsync(int requestOrderId)
    {
        return Task.FromResult(_orders.Find(x => x.Id == requestOrderId));
    }
}