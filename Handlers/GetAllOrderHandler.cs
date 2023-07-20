using MediatR;
using WebApplication1.Dtos;
using WebApplication1.Queries;
using WebApplication1.Repositories;

namespace WebApplication1.Handlers;

public class GetAllOrderHandler : IRequestHandler<GetAllOrderQuery, List<OrderDto>>
{
    private readonly IOrderRepository _orderRepository;

    public GetAllOrderHandler(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }

    public async Task<List<OrderDto>> Handle(GetAllOrderQuery request, CancellationToken cancellationToken)
    {
        var orders = await _orderRepository.GetOrdersAsync();
        
        return orders;
    }
}