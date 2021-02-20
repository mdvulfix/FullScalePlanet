using System;
using UnityEngine;

namespace Source.Map
{
    public class MapContinental: AMap, IMap
    {
        //public GameObject   Obj    {get  => _obj;     protected set => _obj = value;}
        
        public string       Name   {get  => _name;    protected set => _name = value;}
        public int          Width  {get  => _width;   protected set => _width = value;}
        public int          Length {get  => _length;  protected set => _length = value;}
        public float        Scale  {get  => _scale;   protected set => _scale = value;}
        
        public float[,]     Noise  {get  => _noise;   protected set => _noise = value;}    
        

        public override void Awake()
        {

            _name = "Map: Continental";
            transform.gameObject.name = _name;

        }
    
    
    }
}