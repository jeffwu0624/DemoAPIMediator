using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Application.Feature.Order.CreateOrder;
using WebApplication1.Application.Feature.Order.GetAllOrder;
using WebApplication1.Application.Feature.Order.GetOrderById;

namespace WebApplication1.Controllers;

[ApiController]
[Route("[controller]")]
public class OrderController : ControllerBase
{
    private readonly IMediator _mediator;

    public OrderController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllOrders()
    {
        var query = new GetAllOrderQuery();

        var result = await _mediator.Send(query);

        return Ok(result);
    }

    [HttpGet("{orderId}")]
    public async Task<IActionResult> GetOrderById(int orderId)
    {
        var query = new GetOrderByIdQuery(orderId);

        var result = await _mediator.Send(query);

        return result != null
            ? Ok(result)
            : NotFound();
    }
    
    [HttpPost]
    public async Task<IActionResult> CreateOrder([FromBody]CreateOrderCommand command)
    {
        var result = await _mediator.Send(command);

        return CreatedAtAction("GetOrderById", new { orderId = result.Id }, result);
    }
}