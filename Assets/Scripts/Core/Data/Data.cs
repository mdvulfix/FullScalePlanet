using System;

namespace Core
{
    [Serializable]
    public abstract class Data : IData
    {
        public static ICacheData CacheData {get; private set;}
    
    
    
        public virtual void OnAwake(ICacheData dataCache = null)
        {
            if(dataCache == null)
                CacheData = new CacheDataDefault();
            else
                CacheData = dataCache;
        }
    
    
    }
}