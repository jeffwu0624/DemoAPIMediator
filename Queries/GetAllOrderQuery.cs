using MediatR;
using WebApplication1.Dtos;

namespace WebApplication1.Queries;

public class GetAllOrderQuery : IRequest<List<OrderDto>>
{
    
}