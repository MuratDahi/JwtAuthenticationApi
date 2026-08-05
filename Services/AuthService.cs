using BCrypt.Net;
using JwtAuthenticationApi.DTOs;
using JwtAuthenticationApi.Interfaces;
using JwtAuthenticationApi.Models;

namespace JwtAuthenticationApi.Services
{
    public class AuthService : IAuthService
    {
        private readonly IAuthRepository _authRepository;

        public AuthService(IAuthRepository authRepository)
        {
            _authRepository = authRepository;
        }

        public async Task RegisterAsync(RegisterRequestDto request)
        {
            var existingUser = await _authRepository.GetUserByEmailAsync(request.Email);

            if (existingUser != null)
                throw new Exception("Bu email zaten kayıtlı.");

            var user = new User
            {
                Name = request.Name,
                Surname = request.Surname,
                Email = request.Email,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(request.Password)
            };

            await _authRepository.AddUserAsync(user);
        }

        public async Task<TokenResponseDto> LoginAsync(LoginRequestDto request)
        {
            throw new NotImplementedException();
        }
    }
}