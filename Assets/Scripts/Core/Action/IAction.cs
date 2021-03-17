namespace Core
{
    public interface IAction: ICachable
    {
        IBot Bot  {get; } 
        void Execute();


    }
}