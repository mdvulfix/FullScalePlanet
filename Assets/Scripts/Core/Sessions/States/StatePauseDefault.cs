using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Core
{
    public class StatePauseDefault : State
    {
        public string StateName {get  => _stateName; }

        public StatePauseDefault()
        {
            _stateName = "State: Pause";
        }


        public override void Execute()
        {
            Messenger.Send("Execute "  + StateName);


        }
    }
}