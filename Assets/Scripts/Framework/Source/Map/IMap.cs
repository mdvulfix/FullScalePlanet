using UnityEngine;

namespace Source.Map
{
    public interface IMap
    {
        string Name{get;}
        
        int Width{get;}
        int Length{get;}

        void SetGameObject(GameObject obj);
        void SetParametrs(int width, int length, string name = null);


    }
}