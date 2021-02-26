using UnityEngine;
using Source.Map;

namespace Core
{
    public class Load : State
    {


        public string StateName {get  => _stateName; }
        
        public Load()
        {
            _stateName = "State: Load";
        }


        public override void Execute()
        {
            Messenger.Send("Execute "  + StateName);


        }


    }
}