using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Application.Feature.Order.GetAllOrder;

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
}