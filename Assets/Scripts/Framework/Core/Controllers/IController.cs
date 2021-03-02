using System;
namespace Core
{
    public interface IController
    {
        //ISession Session {get; }

        void SetSession(ISession session);

    }
}