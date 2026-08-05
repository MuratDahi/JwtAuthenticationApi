using JwtAuthenticationApi.Models;

namespace JwtAuthenticationApi.Interfaces
{
    public interface IAuthRepository
    {
        Task AddUserAsync(User user);

        Task<User?> GetUserByEmailAsync(string email);

        Task UpdateUserAsync(User user);
    }
}