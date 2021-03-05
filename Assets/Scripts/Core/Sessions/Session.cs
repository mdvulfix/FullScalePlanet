using System;
using System.Collections.Generic;
using UnityEngine;
using Core;
using Handlers;


namespace Core
{
    [Serializable]
    public abstract class Session : SceneObject, ISession, IAwakable
    {
        
        public IStateMachine    StateMachine    {get => _stateMachine; private set => _stateMachine = value as StateMachine;}
        public IState           CurrentState    {get => _currentState; protected set => _currentState = value as State;}
        
        [Header("State"), SerializeField]
        private StateMachine                _stateMachine;
        private State                       _currentState;
        
        private static Dictionary<Type, IControl>  _controls;
        
        protected Session()
        {
            OnAwake();

        }
        
        
        public virtual void OnAwake() 
        {

            _controls = new Dictionary<Type, IControl>();           
            SetStateMachine<StateMachineDefault>(name: "State Machine", obj: this.gameObject, parent: null);
            SetControls();
    

        }
        
        
        public void SetStateMachine<T>(string name, GameObject obj, GameObject parent) where T: SceneObject, IStateMachine, new()
        {
            StateMachine = HandlerComponent.SetComponent<T>(name, obj, parent) as T;
            StateMachine.SetSession(this);

        }   


        public abstract void SetControls();

        public static void AddControl<T>(T value) where T: IControl
        {
            _controls.Add(typeof(T), value);

        }

        public static void RemoveControl<T>(T value) where T: IControl
        {
            _controls.Remove(typeof(T));

        }







    }
}
