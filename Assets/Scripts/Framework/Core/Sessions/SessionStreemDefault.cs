using System;
using UnityEngine;

namespace Core
{
    public class SessionStreemDefault : Session, ISession
    {



        public IStateController StateController { get => _stateController; private set => _stateController = value; }
        public IState CurrentState {get => _currentState; private set => _currentState = value;}
        
        public void Awake() 
        {

            StateController = SetController<StateControllerDefault>("Controller: State", transform) as IStateController;
            CurrentState = StateController.SetState<Initialize>();
        

        
        }

    }
}