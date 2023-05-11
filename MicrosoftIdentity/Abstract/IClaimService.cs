using Microsoft.AspNetCore.Identity;
using MicrosoftIdentity.Entities;
using MicrosoftIdentity.Models;

namespace MGH.Identity.Abstract;

public interface IClaimService
{
    Task<IdentityResult> AddClaimToUser(User user);
    Task<IdentityResult> RemoveClaimsByUser(User user);
    Task<IdentityResult> AssignClaimsToUser(User user, UpdateUser updateUser);
}