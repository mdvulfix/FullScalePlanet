using System;
using UnityEngine;

namespace Core
{
    [Serializable]
    public class ActionMove : Action<Move>
    {
        public DataMove Data {get; } 
        
        public override void Execute()
        {
            Bot.Obj.transform.Translate(Data.Direction * Data.Speed * Time.deltaTime, Space.World);
            
        }

        
        


    }
}
