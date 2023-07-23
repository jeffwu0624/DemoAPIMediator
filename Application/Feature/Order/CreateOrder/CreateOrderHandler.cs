using MediatR;
using WebApplication1.Dtos;

namespace WebApplication1.Application.Feature.Order.CreateOrder;

public class CreateOrderHandler : IRequestHandler<CreateOrderCommand, OrderDto>
{
    private readonly ICreateOrderRepository _repository;

    public CreateOrderHandler(ICreateOrderRepository repository)
    {
        _repository = repository;
    }

    public async Task<OrderDto> Handle(CreateOrderCommand command, CancellationToken cancellationToken)
    {
        var order = new Domain.Order()
        {
            Id = command.Id,
            Name = command.Name
        };
        
        await _repository.CreateOrderAsync(order);

        return new OrderDto()
        {
            Id = order.Id,
            Name = order.Name
        };
    }
}