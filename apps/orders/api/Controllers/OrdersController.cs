using Microsoft.AspNetCore.Mvc;
using Orders.Domain;
using Orders.UseCases;

namespace Orders.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class OrdersController : ControllerBase
{
    private readonly IOrdersCrud _crud;
    private readonly ILogger<OrdersController> _logger;

    public OrdersController(ILogger<OrdersController> logger,
        IOrdersCrud crud)
    {
        _logger = logger;
        _crud = crud;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_crud.Get());
    }

    [HttpPost]
    public IActionResult Post(Order order) 
    {
        _crud.Insert(order);
        return Ok();
    } 
}
