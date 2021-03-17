using System;
using System.Collections.Generic;
using UnityEngine;
using Handlers;

namespace Core
{

    [Serializable]
    public abstract class Bot : Component, IBot
    {
        
        public int ID {get; protected set;}
        public static Dictionary<int, Dictionary<IMechanic, IData>>     DataCache {get; private set;}
        public static Dictionary<int, Dictionary<IMechanic, IAction>>   ActionCache {get; private set;}
        public GameObject Obj {get; private set;}

        public virtual void OnAwake()
        {
            Obj = gameObject;
            
            DataCache = new Dictionary<int, Dictionary<IMechanic, IData>> (100);
            ActionCache = new Dictionary<int, Dictionary<IMechanic, IAction>> (100);
            
            SetParams();       
        
        }
        
        public virtual void OnUpdate()
        {
            OnAction();
        
        }

        
        public abstract void SetParams();

        public virtual void OnAction()
        {
            IAction[] actions = HandlerCache<IAction>.GetAction(this);
            foreach (var action in actions)
            {
                action.Execute();
            }
        
        }
        
        public void Awake() 
        {

            OnAwake();

        }


        public void Update()
        {
            OnUpdate();
        
        }


    }
}