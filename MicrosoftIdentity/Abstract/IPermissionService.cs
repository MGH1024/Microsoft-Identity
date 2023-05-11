using MicrosoftIdentity.Entities;

namespace MicrosoftIdentity.Abstract;

public interface IPermissionService
{
    List<Permission> GetAllPermission();
}