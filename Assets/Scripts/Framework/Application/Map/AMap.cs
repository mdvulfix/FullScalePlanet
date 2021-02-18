using UnityEngine;
using Core.Scene;

namespace Application.Map
{
    public abstract class AMap: MonoBehaviour, IScene
    {
        public GameObject Obj {get; protected set;}
        

    }
}
