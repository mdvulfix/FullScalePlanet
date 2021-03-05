namespace Core
{
    public class Initialize : State
    {

        public string StateName {get  => _stateName; }
        
        public Initialize()
        {
            _stateName = "State: Initialize";
        }


        public override void Execute()
        {
            Messenger.Send("Execute "  + StateName);


        }

    
    
    
    
    
    }
}

