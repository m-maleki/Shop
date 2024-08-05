using MediatR;
using Microsoft.AspNetCore.Identity;

namespace Shop.Application.Features.User.Queries;

public class LoginUserQuery : IRequest<string>, IRequest<List<IdentityError>>
{
    public LoginUserQuery(string email, string password)
    {
        Email = email;
        Password = password;
    }

    public string Email { get; set; }
    public string Password { get; set; }
}