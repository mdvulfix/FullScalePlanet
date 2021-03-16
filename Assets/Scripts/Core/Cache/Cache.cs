using System.Collections.Generic;

namespace Core
{
    public abstract class Cache<T> : ICache where T: ICachable
    {
        public Dictionary<int, HashSet<T>>   Storage {get; } = new Dictionary<int, HashSet<T>>();
        
        public T Set(IBot bot, T instance)
        {           
            var hash = new HashSet<T>();
            hash.Add(instance);
            Storage.Add(bot.GetHashCode(), hash);
            return instance;
        }
        /*
        public static T Get(IBot bot)
        {
            T _instance;
            var hash = new HashSet<T>();
            Storage.TryGetValue(bot.GetHashCode(), out hash);
            //Hash.TryGetValue(typeof(T).GetHashCode(), out _instance);
            
            hash.

            return _instance;
        }
        */
    
    
    
    
    
    }
}



