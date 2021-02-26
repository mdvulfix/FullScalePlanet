using System;
using UnityEngine;
using Handlers;

namespace Core
{
    [Serializable]
    public abstract class StateController : SceneObject, IStateController
    {
              
        [Header("Session"), SerializeField]
        private Session _session;             
        
        public ISession Session {get => _session; protected set => _session = value as Session;}
                
        
        public virtual T SetState<T>(string name = "State: Custom", GameObject obj = null, GameObject parent = null) where T: SceneObject, IState, new()
        {
            var state = ComponentHandler.SetComponent<T>(name, obj, parent);
            return state;

        }

        public virtual void SetSession(ISession session)
        {
            Session = session as Session;

        }
    

    }
}