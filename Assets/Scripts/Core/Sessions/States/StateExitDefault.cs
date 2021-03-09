namespace Core
{

    public class StateExitDefault : State
    {
            public string StateName {get  => _stateName; }
            
            public StateExitDefault()
            {
                _stateName = "State: Exit";
            }


            public override void Execute()
            {
                Messenger.Send("Execute "  + StateName);


            }

    }
}