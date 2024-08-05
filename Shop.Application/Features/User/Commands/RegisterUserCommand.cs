using MediatR;
using Microsoft.AspNetCore.Identity;

namespace Shop.Application.Features.User.Commands;

public class RegisterUserCommand : IRequest<List<IdentityError>>
{
    public RegisterUserCommand(string email, string password)
    {
        Email = email;
        Password = password;
    }

    public string Email { get; set; }
    public string Password { get; set; }
}