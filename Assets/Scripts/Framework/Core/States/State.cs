using System;
using UnityEngine;

namespace Core
{
    [Serializable]
    public abstract class State: SceneObject, IState
    {
        
        [SerializeField] protected string _stateName;  
        
        public State()
        {


        }

        public virtual void Enter()
        {
            Messenger.Send("Enter to " + _stateName);
        }
        
        
        public abstract void Execute();
        
        
        
        public virtual void Exit()
        {
            Messenger.Send("Exit to " + _stateName);


        }




    }
}