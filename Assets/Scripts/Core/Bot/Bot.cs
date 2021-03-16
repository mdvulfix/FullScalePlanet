using System;
using System.Collections.Generic;
using UnityEngine;

namespace Core
{

    [Serializable]
    public abstract class Bot : Component, IBot
    {
        private static Dictionary<int, ICacheData>      _botData    = new Dictionary<int, ICacheData>(50);
        private static Dictionary<int, ICacheActions>   _botActions = new Dictionary<int, ICacheActions>(50);
        
        
        //private IAction[]   _botActions;
        //private ISignal[]   _botSignals;

        public GameObject   Obj {get; private set;}


        public void OnAwake()
        {
            Obj = gameObject;
            //_botData    = new Dictionary<int, ICacheData>(50);
            //_botActions = new Dictionary<int, ICacheActions>(50);

        
        
        }

        
        public static IData SetData(IBot bot, IMechanic mechanic, IData instance, ICacheData cache)
        {           
            cache.Set(mechanic, instance);
            _botData.Add(bot.GetHashCode(), cache);
            return instance;
        }
        
        public static IAction SetData(IBot bot, IMechanic mechanic, IAction instance, ICacheActions cache)
        {           
            cache.Set(mechanic, instance);
            _botActions.Add(bot.GetHashCode(), cache);
            return instance;
        }
        
        
        
        
        
        
        
        
        public void OnUpdate()
        {
            OnAction();

        }



        public void OnAction()
        {
            foreach (var action in _botActions)
            {
                //action.Execute(this);
            }
        }

        public void OnSignal()
        {

        }

    }
}