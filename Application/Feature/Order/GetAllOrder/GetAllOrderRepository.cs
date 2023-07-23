using WebApplication1.Dtos;
using WebApplication1.Repositories;

namespace WebApplication1.Application.Feature.Order.GetAllOrder;

public class GetAllOrderRepository : IGetAllOrderRepository
{
    public Task<List<OrderDto>> GetOrdersAsync()
    {
        return Task.FromResult(MockOrderRepository.GetAll().Select(x => new OrderDto
        {
            Id = x.Id,
            Name = x.Name
        }).ToList());
    }
}