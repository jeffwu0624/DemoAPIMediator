using MediatR;
using WebApplication1.Dtos;

namespace WebApplication1.Application.Feature.Order.GetOrderById;

public class GetOrderByIdHandler : IRequestHandler<GetOrderByIdQuery, OrderDto>
{
    private readonly IGetOrderByIdRepository _repository;

    public GetOrderByIdHandler(IGetOrderByIdRepository repository)
    {
        _repository = repository;
    }
    
    public async Task<OrderDto> Handle(GetOrderByIdQuery request, CancellationToken cancellationToken)
    {
        return await _repository.findById(request.OrderId);
    }
}