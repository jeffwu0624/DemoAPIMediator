using MediatR;
using WebApplication1.Dtos;

namespace WebApplication1.Application.Feature.Order.CreateOrder;

public class CreateOrderCommand : IRequest<OrderDto>
{
    public int Id { get; set; }

    public string Name { get; set; }
}