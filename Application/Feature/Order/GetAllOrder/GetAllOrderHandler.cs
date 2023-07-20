using MediatR;
using WebApplication1.Dtos;

namespace WebApplication1.Application.Feature.Order.GetAllOrder;

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