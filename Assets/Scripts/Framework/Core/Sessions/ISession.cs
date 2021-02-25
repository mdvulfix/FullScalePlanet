
namespace Core
{
    public interface ISession
    {

        IStateController StateController {get; }
        IState CurrentState {get; }
    }
}