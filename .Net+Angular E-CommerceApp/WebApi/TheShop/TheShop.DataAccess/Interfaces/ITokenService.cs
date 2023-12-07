using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheShop.Domain.Entities.Identity;

namespace TheShop.DataAccess.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}
