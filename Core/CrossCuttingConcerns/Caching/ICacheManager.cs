using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcerns.Caching
{
   public interface ICacheManager
    {
        T Get<T>(string key);
        object Get(string key);
        void Add(string key, object value, int duration);

        bool IsAdd(string key);//cache belleğe ekle
        void Remove(string key);//cache den uçur
        void RemoveByPattern(string pattern);//için'get'olanları mesala uçur
    }
}
