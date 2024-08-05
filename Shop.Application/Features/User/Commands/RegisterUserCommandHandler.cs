using MediatR;
using Shop.Domain.User.Entities;
using Microsoft.AspNetCore.Identity;

namespace Shop.Application.Features.User.Commands;

public class RegisterUserCommandHandler : IRequestHandler<RegisterUserCommand, List<IdentityError>>
{
    private readonly UserManager<ApplicationUser> _userManager;

    public RegisterUserCommandHandler(UserManager<ApplicationUser> userManager)
    {
        _userManager = userManager;
    }

    public async Task<List<IdentityError>> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
    {
        var user = new ApplicationUser
        {
            Email = request.Email,
            UserName = request.Email
        };

        var result = await _userManager.CreateAsync(user, request.Password);

        return (List<IdentityError>)result.Errors;
    }
}