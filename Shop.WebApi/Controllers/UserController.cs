using MediatR;
using Microsoft.AspNetCore.Mvc;
using Shop.Application.Utility;
using Shop.Application.Features.User.Queries;
using Shop.Application.Features.User.Commands;

namespace Shop.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly IMediator _mediator;

    public UserController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    [Route(nameof(Register))]
    public async Task<IActionResult> Register(string email, string password, CancellationToken cancellationToken)
    {
        if (!email.IsValidEmail())
            return ValidationProblem();

        var query = new RegisterUserCommand(email, password);
        return Ok(await _mediator.Send(query, cancellationToken));
    }

    [HttpGet]
    [Route(nameof(Login))]
    public async Task<IActionResult> Login(string email, string password, CancellationToken cancellationToken)
    {
        if (!email.IsValidEmail())
            return ValidationProblem();

        var query = new LoginUserQuery(email, password);
        return Ok(await _mediator.Send(query, cancellationToken));
    }
}