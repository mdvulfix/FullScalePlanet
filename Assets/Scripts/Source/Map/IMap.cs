using UnityEngine;

namespace Source.Map
{
    public interface IMap
    {
        //GameObject   Obj    {get;}
        
        string       Name   {get;}
        int          Width  {get;}
        int          Length {get;}
        float        Scale  {get;}
        
        float[,]     Noise  {get;}

        void SetParametrs(int width, int length, float scale, GameObject obj, string massege);

    }
}