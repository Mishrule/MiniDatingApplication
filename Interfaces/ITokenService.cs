using D.API.Entities;

namespace D.API.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}
