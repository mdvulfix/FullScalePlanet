using System;
using UnityEngine;
using Handlers;


namespace Core
{
    [Serializable]
    public class Session : SceneObject
    {
        [Header("Controllers")]
        protected IStateController _stateController;

        [Header("State")]
        protected IState _currentState;
               
        
        
        
        public IController SetController<T>(string name, Transform parent) where T: SceneObject, IController, new()
        {
            var controller = ComponentHandler.AddController<T>(name, parent) as IController;
            return controller;

        }








    }
}
