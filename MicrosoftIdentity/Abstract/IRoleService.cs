﻿using Microsoft.AspNetCore.Identity;
using MicrosoftIdentity.Entities;

namespace MicrosoftIdentity.Abstract;

public interface IRoleService
{
    Task<IdentityResult> AddRoleToUser(User user, int roleId);
    Task<List<Role>> GetRoleListByUser(User user);
    Task<IdentityResult> RemoveRolesByUser(User user);
    Task<IdentityResult> AssignRolesToUser(User user, List<int> roleId);
    Task<Role> GetById(int roleId);
}