namespace Core
{
    public abstract class Action<T> : IAction where T : IMechanic
    {
        public IBot Bot  {get; private set;} 
        
        public Action()
        {


        }
        
        public void SetBot(IBot bot)
        {
            Bot = bot;

        }
        
        
        public abstract void Execute();
    }
}
