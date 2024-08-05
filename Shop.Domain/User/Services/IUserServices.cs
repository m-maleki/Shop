namespace Shop.Domain.User.Services
{
    public interface IUserServices
    {
        string GenerateAccessToken(string email);
    }
}
