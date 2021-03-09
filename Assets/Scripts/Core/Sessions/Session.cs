using System;
using System.Collections.Generic;
using UnityEngine;
using Core;
using Handlers;


namespace Core
{
    [Serializable]
    public abstract class Session : Component, ISession
    {
        public IStateMachine    StateMachine    {get => _stateMachine; private set => _stateMachine = value as StateMachine;}
        public IState           CurrentState    {get => _currentState; protected set => _currentState = value as State;}
        

        [Header("State"), SerializeField]
        private StateMachine    _stateMachine;
        private State           _currentState;
   
        protected abstract void SetStateAwake();
        protected abstract void SetStateLoad();
        protected abstract void SetStatePlay();
        protected abstract void SetStatePause();
        protected abstract void SetStateExit();
        
        protected void Awake()
        {
            SetStateMachine();
        }
        
        
        protected void SetStateMachine() 
        {          
            SetStateMachine<StateMachineDefault>(obj: gameObject);

        }
        
        private void SetStateMachine<T>(string name = "State Machine", GameObject obj = null, GameObject parent = null) where T: Core.Component, IStateMachine, new()
        {
            StateMachine = HandlerComponent.GetComponent<T>(name, obj, parent) as T;
            StateMachine.SetSession(this);

        }   




 




    }
}
