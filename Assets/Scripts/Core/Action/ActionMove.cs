using UnityEngine;

namespace Core
{
    public class ActionMove : Action
    {
        
        
        public DataMove Data {get; } 
        
        
        public override void Execute(IBot bot)
        {
            bot.Obj.transform.Translate(new Vector3(0, 0, 1) * Data.Speed * Time.deltaTime, Space.World);
            

        }

        
        


    }
}
