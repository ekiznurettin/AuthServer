using CoreLayer.Configuration;
using EntitiesLayer.Concrete;
using EntitiesLayer.Dtos;

namespace BusinessLayer.Abstract
{
    public interface ITokenService
    {
        TokenDto CreateToken(UserApp userApp);
        ClientTokenDto CreateTokenByClient(Client client);
    }
}
