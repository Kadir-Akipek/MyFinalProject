using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Concrete;

namespace Core.Utilities.Security.Jwt
{
    public interface ITokenHelper
    {
        //İlgili kullanıcının Claim'lerini içerecek bir Token üretecek
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}
