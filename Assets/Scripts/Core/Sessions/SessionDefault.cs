using UnityEngine;

namespace Core
{

    public class SessionDefault : Session
    {
        protected override void SetStateAwake()
        {
            StateMachine.SetState<StateAwakeDefault>();

        }

        protected override void SetStateLoad()
        {
            StateMachine.SetState<StateLoadDefault>();

        }

        protected override void SetStatePlay()
        {
            StateMachine.SetState<StatePlayDefault>();

        }

        protected override void SetStatePause()
        {
            StateMachine.SetState<StatePauseDefault>();

        }

        protected override void SetStateExit()
        {
            StateMachine.SetState<StateExitDefault>();

        }
        
        

    }
}