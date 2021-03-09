using System;
using UnityEngine;
using Handlers;

namespace Core
{
    [Serializable]
    public abstract class StateMachine : Component, IStateMachine
    {
        public GameObject   SceneObject {get; } 
        public ISession     Session {get => _session; protected set => _session = value as Session;}
                
        //[SerializeField]
        private Session _session;
        
        public virtual T SetState<T>(string name = "State: Custom", GameObject obj = null, GameObject parent = null) where T: IState, new()
        {
            var state = new T();
            return state;

        }

        public virtual void SetSession(ISession session)
        {
            Session = session as Session;

        }
    

    }
}