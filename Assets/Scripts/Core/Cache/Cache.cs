using System.Collections.Generic;

namespace Core
{
    public abstract class Cache<T> : ICache where T: ICachable
    {
        private Dictionary<IMechanic, T> _storage;
 
        public T Set(IMechanic mechanic, T instance)
        {           
            _storage.Add(mechanic, instance);
            return instance;
        }
        
        public T Get(IMechanic mechanic)
        {
            T instance;
            _storage.TryGetValue(mechanic, out instance);
            return instance;
        }
        
    
    
    
    
    
    }
}



