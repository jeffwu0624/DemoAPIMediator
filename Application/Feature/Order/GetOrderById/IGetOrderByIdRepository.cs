using WebApplication1.Dtos;

namespace WebApplication1.Application.Feature.Order.GetOrderById;

public interface IGetOrderByIdRepository
{
    Task<OrderDto> findByIdAsync(int requestOrderId);
}