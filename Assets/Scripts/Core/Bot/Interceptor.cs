using System;
using System.Collections.Generic;
using UnityEngine;
using Handlers;

namespace Core
{
    [Serializable]
    public class Interceptor: Bot
    {
        
        public DataMove     DataMove    {get; private set;}
        public ActionMove   ActionMove  {get; private set;}

        
        public List<object> list;
        
        
        public override void SetParams()
        {
            
           ID = 1; 
            
            
            DataMove = HandlerCache<DataMove>.SetData<Move>(this, new DataMove(20));
            
            ActionMove = new ActionMove();
            ActionMove.SetBot(this);
            
            HandlerCache<ActionMove>.SetAction<Move>(this, ActionMove);
        }
    
    
    }
}