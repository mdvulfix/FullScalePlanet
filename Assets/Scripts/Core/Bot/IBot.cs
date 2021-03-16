using UnityEngine;

namespace Core
{
    public interface IBot
    {

        IData       Data    {get; }
        IAction     Action  {get; }
        
        GameObject  Obj     {get; }
        
        void OnAction();

    }
}