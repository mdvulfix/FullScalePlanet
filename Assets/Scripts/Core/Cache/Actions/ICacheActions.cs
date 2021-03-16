namespace Core
{
    public interface ICacheActions
    {

        IAction Set(IMechanic mechanic, IAction instance);
        IAction Get(IMechanic mechanic);

    }
}
