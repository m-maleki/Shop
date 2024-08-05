using MediatR;
using Microsoft.AspNetCore.Mvc;
using Shop.Application.Utility;
using Shop.Domain.Product.Dtos;
using Microsoft.AspNetCore.Authorization;
using Shop.Application.Features.Product.Queries.GetAll;
using Shop.Application.Features.Product.Commands.Create;
using Shop.Application.Features.Product.Commands.Delete;
using Shop.Application.Features.Product.Commands.Update;
using Shop.Application.Features.Product.Queries.GetById;

namespace Shop.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    private readonly IMediator _mediator;

    public ProductController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    [Route(nameof(Get))]
    public async Task<GetProductDto> Get(int id, CancellationToken cancellationToken)
    {
        var query = new GetProductByIdQuery(id);
        var products = await _mediator.Send(query, cancellationToken);
        return products;
    }

    [HttpGet]
    [Route(nameof(GetAll))]
    public async Task<List<GetProductDto>> GetAll(CancellationToken cancellationToken)
    {
        var query = new GetAllProductQuery();
        var products = await _mediator.Send(query, cancellationToken);
        return products;
    }

    [HttpDelete]
    [Route(nameof(Delete))]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<IActionResult> Delete(int id, CancellationToken cancellationToken)
    {
        var query = new DeleteProductCommand(id);
        return Ok(await _mediator.Send(query, cancellationToken));
    }

    [HttpPost]
    [Route(nameof(Create))]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<IActionResult> Create(CreateProductDto model, CancellationToken cancellationToken)
    {
        if (!model.ManufactureEmail.IsValidEmail() || !model.ManufacturePhone.IsValidMobileNumber())
            return ValidationProblem();

        var query = new CreateProductQuery(model);
        return Ok(await _mediator.Send(query, cancellationToken));
    }

    [HttpPut]
    [Route(nameof(Update))]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<IActionResult> Update(UpdateProductDto model, CancellationToken cancellationToken)
    {
        if (!model.ManufacturePhone.IsValidMobileNumber())
            return ValidationProblem();

        var query = new UpdateProductCommand(model);
        return Ok(await _mediator.Send(query, cancellationToken));
    }
}