namespace Core
{
    public class StateAwakeDefault : State
    {

        public string StateName {get  => _stateName; }
        
        
        
        public StateAwakeDefault()
        {
            _stateName = "State: Awake";
            Execute();
        }


        public override void Execute()
        {
            Messenger.Send("Execute "  + StateName);


        }

        public void SetControls()
        {
  


        }

        //public virtual void SetControls()

        public static void AddControl<T>(T value) where T: IControl
        {
            //_controls.Add(typeof(T), value);

        }

        public static void RemoveControl<T>(T value) where T: IControl
        {
            //_controls.Remove(typeof(T));

        }

    
    
    
    
    
    }
}

