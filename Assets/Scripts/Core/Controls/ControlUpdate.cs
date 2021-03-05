using UnityEngine;

namespace Core
{
    public abstract class ControlUpdate: IControlUpdate
    {

        public ISession Session {get => _session; protected set => _session = value as Session;}
        private Session _session;  
        
        
        protected ControlUpdate(ISession session)
        {
            SetSession(session);

        }

#region Session
        public virtual void SetSession(ISession session)
        {
            _session = session as Session;

        }
#endregion
    
    
    
    
    
    
    
    
    }
}