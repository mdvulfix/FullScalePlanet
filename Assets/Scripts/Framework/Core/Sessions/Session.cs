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
        

        [Header("State"), SerializeField]
        private StateMachine    _stateMachine;
        private State           _currentState;
        
                       
        public ISceneController SceneController {get => _sceneController; protected set => _sceneController = value as SceneController;}
        
        public IStateMachine    StateMachine    {get => _stateMachine; protected set => _stateMachine = value as StateMachine;}
        public IState           CurrentState    {get => _currentState; protected set => _currentState = value as State;}
       
        
        protected virtual void Awake() 
        {
            
            SetStateMachine<StateMachineDefault>(name: "State Machine", obj: this.gameObject, parent: null);
            CurrentState = _stateMachine.SetState<Initialize>(name: "State: Initialize", obj: null, parent: this.gameObject);

            SceneController = SetController<SceneControllerDefault>(name: "Controller: Scene", obj: this.gameObject, parent: null);
            SceneController.SetSceneStorage<SceneStorageDefault>(name: "Scene: Default", obj: null, parent: this.gameObject);
        }
        
        
        
        
        public void SetStateMachine<T>(string name, GameObject obj, GameObject parent) where T: SceneObject, IStateMachine, new()
        {
            StateMachine = ComponentHandler.SetComponent<T>(name, obj, parent) as T;
            StateMachine.SetSession(this);

        }   
        
        
        public T SetController<T>(string name, GameObject obj, GameObject parent) where T: SceneObject, IController, new()
        {
            var controller = ComponentHandler.SetComponent<T>(name, obj, parent) as T;
            controller.SetSession(this);
            
            return controller;

        }








    }
}
