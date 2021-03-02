using System;
using UnityEngine;
using Core;
using Handlers;


namespace Core
{
    [Serializable]
    public abstract class Session : SceneObject, ISession
    {
        [Header("Controllers")]
        [SerializeField] private SceneController _sceneController;
        [SerializeField] private StateController _stateController;

        [Header("State"), SerializeField]
        private State _currentState;
                       
        
        public ISceneController SceneController {get => _sceneController; protected set => _sceneController = value as SceneController;}
        public IStateController StateController {get => _stateController; protected set => _stateController = value as StateController;}
        public IState CurrentState              {get => _currentState; protected set => _currentState = value as State;}
       
        
        protected virtual void Awake() 
        {
            
            StateController = SetController<StateControllerDefault>(name: "Controller: State", obj: this.gameObject, parent: null);
            CurrentState = StateController.SetState<Initialize>(name: "State: Initialize", obj: null, parent: this.gameObject);

            SceneController = SetController<SceneControllerDefault>(name: "Controller: Scene", obj: this.gameObject, parent: null);
            SceneController.SetSceneStorage<SceneStorageDefault>(name: "Scene: Default", obj: null, parent: this.gameObject);
        }
        
        
        
        
        
        
        public T SetController<T>(string name, GameObject obj, GameObject parent) where T: SceneObject, IController, new()
        {
            var controller = ComponentHandler.SetComponent<T>(name, obj, parent) as T;
            controller.SetSession(this);
            
            return controller;

        }








    }
}
