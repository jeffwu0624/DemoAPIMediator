using MediatR;
using WebApplication1.Dtos;

namespace WebApplication1.Application.Feature.Order.GetAllOrder;

public class GetAllOrderHandler : IRequestHandler<GetAllOrderQuery, List<OrderDto>>
{
    private readonly IGetAllOrderRepository _getAllOrderRepository;

    public GetAllOrderHandler(IGetAllOrderRepository getAllOrderRepository)
    {
        _getAllOrderRepository = getAllOrderRepository;
    }

    public async Task<List<OrderDto>> Handle(GetAllOrderQuery request, CancellationToken cancellationToken)
    {
        var orders = await _getAllOrderRepository.GetOrdersAsync();
        
        return orders;
    }
}