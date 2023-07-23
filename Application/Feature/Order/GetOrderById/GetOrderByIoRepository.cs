using WebApplication1.Dtos;
using WebApplication1.Repositories;

namespace WebApplication1.Application.Feature.Order.GetOrderById;

public class GetOrderByIoRepository : IGetOrderByIdRepository
{
    public Task<OrderDto> findByIdAsync(int requestOrderId)
    {
        return Task.FromResult(MockOrderRepository.GetOrder().First(x => x.Id == requestOrderId));
    }
}