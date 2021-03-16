namespace Core
{
    public interface IAction: ICachable
    {
        void Execute(IBot bot);


    }
}