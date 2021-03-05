using System;
namespace Core
{
    public interface IControl
    {
        ISession Session {get; }
        void SetSession(ISession session);

    }
}