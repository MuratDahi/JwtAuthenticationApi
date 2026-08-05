using JwtAuthenticationApi.DTOs;

namespace JwtAuthenticationApi.Interfaces
{
    public interface IAuthService
    {
        Task RegisterAsync(RegisterRequestDto request);

        Task<TokenResponseDto> LoginAsync(LoginRequestDto request);
    }
}