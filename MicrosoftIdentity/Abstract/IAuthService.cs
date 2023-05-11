using MicrosoftIdentity.Entities;
using MicrosoftIdentity.Enums;
using MicrosoftIdentity.Models;

namespace MicrosoftIdentity.Abstract;

public interface IAuthService
{
    Task<AuthResponse> Login(AuthRequest authRequest, string ipAddress, string returnUrl);
    Task<List<string>> CreateUserByRoleWithoutPassword(CreateUser createUserDto, Roles roles);
    Task<List<string>> CreateUserInUserRole(User user, string password, Roles roles);
    Task<AuthResponse> Refresh(RefreshToken refreshToken, string ipAddress);
}