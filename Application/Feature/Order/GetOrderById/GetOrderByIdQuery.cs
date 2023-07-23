using MediatR;
using WebApplication1.Dtos;

namespace WebApplication1.Application.Feature.Order.GetOrderById;

public class GetOrderByIdQuery : IRequest<OrderDto>
{
    public int OrderId { get; set; }
    
    public GetOrderByIdQuery(int orderId)
    {
        OrderId = orderId;
    }
}