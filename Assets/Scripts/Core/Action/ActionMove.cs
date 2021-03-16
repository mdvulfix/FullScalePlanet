using System;
using UnityEngine;

namespace Core
{
    [Serializable]
    public class ActionMove : Action<Move>
    {
        
        
        public DataMove Data {get; } 
        
        
        public override void Execute(IBot bot)
        {
            bot.Obj.transform.Translate(new Vector3(0, 0, 1) * Data.Speed * Time.deltaTime, Space.World);
            

        }

        
        


    }
}
