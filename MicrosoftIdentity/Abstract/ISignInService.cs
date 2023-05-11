using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using MicrosoftIdentity.Entities;
using MicrosoftIdentity.Models;

namespace MicrosoftIdentity.Abstract;

public interface ISignInService
{
    Task SignOut();
    Task<SignInResult> SignIn(User user, AuthRequest login);
    Task<IEnumerable<Claim>> GetClaimByUser(User user);
}