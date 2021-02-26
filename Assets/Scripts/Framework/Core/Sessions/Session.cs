using System;
using UnityEngine;
using Core;
using Handlers;


namespace Core
{
    [Serializable]
    public abstract class Session : SceneObject, ISession
    {
        [Header("Controllers"), SerializeField]
        private StateController _stateController;

        [Header("State"), SerializeField]
        private State _currentState;
                       
        
        
        public IStateController StateController {get => _stateController; protected set => _stateController = value as StateController;}
        public IState CurrentState              {get => _currentState; protected set => _currentState = value as State;}
       
        
        protected virtual void Awake() 
        {
            StateController = SetController<StateControllerDefault>("Controller: State", null, this.gameObject);
            CurrentState = StateController.SetState<Initialize>("State: Initialize", this.gameObject, null);
        }
        
        
        
        
        
        
        public T SetController<T>(string name, GameObject obj, GameObject parent) where T: SceneObject, IController, new()
        {
            var controller = ComponentHandler.SetComponent<T>(name, obj, parent) as T;
            controller.SetSession(this);
            
            return controller;

        }








    }
}
