namespace Core
{

    public class Exit : State
    {
            public string StateName {get  => _stateName; }
            
            public Exit()
            {
                _stateName = "State: Exit";
            }


            public override void Execute()
            {
                Messenger.Send("Execute "  + StateName);


            }

    }
}