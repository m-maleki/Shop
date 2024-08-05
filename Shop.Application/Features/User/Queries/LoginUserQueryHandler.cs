using MediatR;
using Shop.Domain.User.Entities;
using Shop.Domain.User.Services;
using Microsoft.AspNetCore.Identity;

namespace Shop.Application.Features.User.Queries;

public class LoginUserQueryHandler : IRequestHandler<LoginUserQuery, string>
{
    private readonly SignInManager<ApplicationUser> _signInManager;
    private readonly IUserServices _userServices;

    public LoginUserQueryHandler(SignInManager<ApplicationUser> signInManager,
        IUserServices userServices)
    {
        _signInManager = signInManager;
        _userServices = userServices;
    }

    public async Task<string> Handle(LoginUserQuery request, CancellationToken cancellationToken)
    {
        var loginResult = await _signInManager.PasswordSignInAsync(request.Email, request.Password, true, false);

        if (loginResult.Succeeded) 
            return _userServices.GenerateAccessToken(request.Email);

        return "Username or password is invalid!";
    }
}