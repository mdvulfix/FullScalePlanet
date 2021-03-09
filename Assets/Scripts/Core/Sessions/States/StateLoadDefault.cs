using UnityEngine;
using Source.Map;

namespace Core
{
    public class StateLoadDefault : State
    {


        public string StateName {get  => _stateName; }
        
        public StateLoadDefault()
        {
            _stateName = "State: Load";
        }


        public override void Execute()
        {
            Messenger.Send("Execute "  + StateName);


        }


    }
}