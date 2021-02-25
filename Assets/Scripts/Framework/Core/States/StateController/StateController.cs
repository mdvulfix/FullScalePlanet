using System;
using UnityEngine;

namespace Core
{
    [Serializable]
    public class StateController : Controller
    {
              
        public virtual IState SetState<T>() where T: IState, new()
        {
            var state = new T() as IState;
            return state;

        }
    
    
        
    
    
    
    }
}