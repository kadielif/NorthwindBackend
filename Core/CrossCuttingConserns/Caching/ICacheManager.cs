using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConserns.Caching
{
    public interface ICacheManager
    {
        T Get<T>(string key); //cashe okuma operasyonu
        object Get(string key);
        void Add(string key, object data, int duration); //cashe ekleme operasyonu, cashe de kalma süreside verilir
        bool IsAdd(string key);
        void Remove(string key); //cashe in ortadan kaldırılması
        void RemoveByPattern(string pattern); 
    }
}
