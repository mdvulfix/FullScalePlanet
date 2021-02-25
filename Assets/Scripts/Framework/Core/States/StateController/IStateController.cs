namespace Core
{

    public interface IStateController: IController
    {
        IState SetState<T>() where T: IState, new();

    }
}