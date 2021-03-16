using System;

namespace Core
{
    [Serializable]
    public abstract class Action : IAction
    {
        public static ICacheActions CacheActions {get; private set;}
        
        public IData Date {get; }
        
        
        
        
        public abstract void Execute(IBot bot);

        
        

        public virtual void OnAwake(ICacheActions actionCache = null)
        {
            if(actionCache == null)
                CacheActions = new CacheActionsDefault();
            else
                CacheActions = actionCache;
            
        }
    }
}
