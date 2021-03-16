namespace Core
{
    public interface ICacheData
    {
        IData Set(IMechanic mechanic, IData instance);
        IData Get(IMechanic mechanic);


    }
}
