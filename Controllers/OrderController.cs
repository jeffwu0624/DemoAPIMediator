using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Queries;
using WebApplication1.Repositories;

namespace WebApplication1.Controllers;

[ApiController]
[Route("[controller]")]
public class OrderController : ControllerBase
{
    private readonly IMediator _mediator;
    private readonly IOrderRepository _orderRepository;

    public OrderController(IMediator mediator, IOrderRepository orderRepository)
    {
        _mediator = mediator;
        _orderRepository = orderRepository;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllOrders()
    {
        var query = new GetAllOrderQuery();
        
        var result = await _mediator.Send(query);
        
        return Ok(result);
    }
}