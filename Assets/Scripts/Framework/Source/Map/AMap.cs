using UnityEngine;
using Core.Scene;

namespace Source.Map
{
    public abstract class AMap: MonoBehaviour, IScene
    {
        public GameObject Obj {get; protected set;}
        

    }
}
