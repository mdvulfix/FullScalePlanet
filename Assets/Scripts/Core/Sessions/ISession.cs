
namespace Core
{
    public interface ISession
    {

        IStateMachine   StateMachine {get; }
        IState          CurrentState {get; }
    
    }
}