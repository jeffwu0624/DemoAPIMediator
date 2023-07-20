using WebApplication1.Dtos;

namespace WebApplication1.Application.Feature.Order.GetAllOrder;

public interface IOrderRepository
{
    Task<List<OrderDto>> GetOrdersAsync();
}