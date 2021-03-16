using System;
using UnityEngine;

namespace Core
{

    [Serializable]
    public abstract class Bot : Component, IBot
    {

        
        public IData        Data    {get; }
        public IAction      Action  {get; }

        public GameObject   Obj     {get; private set;}


       public void OnAwake()
        {
            Obj = gameObject;

        }
        
        
        
        public void OnAction()
        {
            Action.Execute(this);

        }

    }
}