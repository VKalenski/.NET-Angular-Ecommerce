#region Usings
using Core.Entities.Identity;
#endregion

namespace Core.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}