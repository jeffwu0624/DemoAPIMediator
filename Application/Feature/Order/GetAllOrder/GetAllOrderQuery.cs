using MediatR;
using WebApplication1.Dtos;

namespace WebApplication1.Application.Feature.Order.GetAllOrder;

public class GetAllOrderQuery : IRequest<List<OrderDto>>
{
    
}