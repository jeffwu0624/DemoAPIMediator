using WebApplication1.Dtos;

namespace WebApplication1.Application.Feature.Order.GetAllOrder;

public interface IGetAllOrderRepository
{
    Task<List<OrderDto>> GetOrdersAsync();
}