using UnityEngine;

namespace Core
{
    public interface IBot
    {       
        GameObject    Obj     {get; }
        
        void OnAction();

    }
}