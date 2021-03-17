using System.Collections.Generic;

namespace Core
{
    public static class Cache<T> 
        where T: ICachable
    {
        public static Dictionary<IMechanic, T> Storage {get; } = new Dictionary<IMechanic, T>(100);
 
        public static T Set<M>(T instance) 
            where M: IMechanic
        {           
            Storage.Add(typeof(M) as IMechanic, instance);
            return instance;
        }
        
        public static T Get<M>()
            where M: IMechanic
        {
            T instance;
            Storage.TryGetValue(typeof(M) as IMechanic, out instance);
            return (T)instance;
        }
    }
}



