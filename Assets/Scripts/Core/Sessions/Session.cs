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
        [SerializeField] private ControlScene _sceneControl;
        

        [Header("State"), SerializeField]
        private StateMachine    _stateMachine;
        private State           _currentState;
        
                       
        public IControlScene    ControlScene    {get => _sceneControl; protected set => _sceneControl = value as ControlScene;}
        
        public IStateMachine    StateMachine    {get => _stateMachine; protected set => _stateMachine = value as StateMachine;}
        public IState           CurrentState    {get => _currentState; protected set => _currentState = value as State;}
       
        
        protected virtual void Awake() 
        {
            
            SetStateMachine<StateMachineDefault>(name: "State Machine", obj: this.gameObject, parent: null);
            CurrentState = _stateMachine.SetState<Initialize>(name: "State: Initialize", obj: null, parent: this.gameObject);

            ControlScene = SetController<ControlSceneDefault>(name: "Controller: Scene", obj: this.gameObject, parent: null);
            ControlScene.SetSceneStorage<StorageSceneDefault>(name: "Scene: Default", obj: null, parent: this.gameObject);
        }
        
        
        
        
        public void SetStateMachine<T>(string name, GameObject obj, GameObject parent) where T: SceneObject, IStateMachine, new()
        {
            StateMachine = HandlerComponent.SetComponent<T>(name, obj, parent) as T;
            StateMachine.SetSession(this);

        }   
        
        
        public T SetController<T>(string name, GameObject obj, GameObject parent) where T: SceneObject, IControl, new()
        {
            var controller = HandlerComponent.SetComponent<T>(name, obj, parent) as T;
            controller.SetSession(this);
            
            return controller;

        }








    }
}
