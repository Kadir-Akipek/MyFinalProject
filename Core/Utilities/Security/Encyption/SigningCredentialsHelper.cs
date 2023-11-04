using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace Core.Utilities.Security.Encyption
{
    public class SigningCredentialsHelper
    {
        public static SigningCredentials CreateSigningCredentials(SecurityKey securityKey) //credentials = kimlik bilgileri
        {
            return  new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature); //API'ye hangi anahtarı ve hangi algoritmayı kullanacağımızı verdik
        }
    }
}
