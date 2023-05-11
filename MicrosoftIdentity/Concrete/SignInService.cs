using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using MicrosoftIdentity.Abstract;
using MicrosoftIdentity.Entities;
using MicrosoftIdentity.Models;

namespace MicrosoftIdentity.Concrete;

public class SignInService : ISignInService
{
    private readonly SignInManager<User> _signInManager;

    public SignInService(SignInManager<User> signInManager)
    {
        _signInManager = signInManager ?? throw new ArgumentNullException(nameof(signInManager));
    }

    public async Task SignOut()
    {
        await _signInManager.SignOutAsync();
    }

    public async Task<SignInResult> SignIn(User user, AuthRequest login)
    {
        return await _signInManager.PasswordSignInAsync
            (user.UserName,
            login.Password,
            login.RememberMe,
            lockoutOnFailure: true);
    }

    public async Task<IEnumerable<Claim>> GetClaimByUser(User user)
    {
        return await _signInManager.UserManager.GetClaimsAsync(user);
    }
}