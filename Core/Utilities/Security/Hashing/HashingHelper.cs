using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Hashing
{
    public class HashingHelper//Tool olduğu için class çıplak kalabilir
    {
        //out'u dışarıya verilecek değer gibi düşün
        public static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt) //out keyword'unu birden fazla veriyi döndürmek için kullanırız
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key; //Key her kullanıcı için farklıdır
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password)); //string'i byte olarak aldık
            }
        }

        public static bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i]!=passwordHash[i])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
