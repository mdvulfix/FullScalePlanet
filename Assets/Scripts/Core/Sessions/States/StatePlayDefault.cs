using UnityEngine;
using Source.Map;

namespace Core
{
    public class StatePlayDefault : State
    {

        public string StateName {get  => _stateName; }
        
        public StatePlayDefault()
        {
            _stateName = "State: Play";
        }


        public override void Execute()
        {
            Messenger.Send("Execute "  + StateName);


        }




    }
}