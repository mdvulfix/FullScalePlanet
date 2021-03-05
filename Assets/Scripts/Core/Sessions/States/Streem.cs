using UnityEngine;
using Source.Map;

namespace Core
{
    public class Streem : State
    {

        public string StateName {get  => _stateName; }
        
        public Streem()
        {
            _stateName = "State: Streem";
        }


        public override void Execute()
        {
            Messenger.Send("Execute "  + StateName);


        }




    }
}