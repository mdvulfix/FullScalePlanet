using UnityEngine;

namespace Core
{
    public interface IStateMachine
    {
        
        void SetSession(ISession session);
        T SetState<T>(string name = "State: Custom", GameObject obj = null, GameObject parent = null) where T: IState, new();
        

    }
}