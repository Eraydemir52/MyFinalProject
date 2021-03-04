using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Hashing
{
    public class HashingHelper
    {
        public static void CreatePasswordHash(string password,out byte[] passwordHash,out byte[] passwordSalt)//dışarı verilcek değer out stringbiz veriyoruz outla alıyoru
        {
            using (var hmac=new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;//her kulanıcı için ayrı key tutar
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));//-->by değerini almak içim

            }
        }
        public static bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)//doğrula passwordhash//bu haşleri karşılaştırır
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))//doğrulanacak parametre
            {
               var computeHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));//compute=hesaplama
                for (int i = 0; i < computeHash.Length; i++)
                {
                    if (computeHash[i]!=passwordHash[i])//verdiğim değerin veri tabanındaki karşılıyomu
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
