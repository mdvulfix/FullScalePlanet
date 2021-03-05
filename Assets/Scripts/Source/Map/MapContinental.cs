using System;
using UnityEngine;
using Core.Noise;
using Handlers;

namespace Source.Map
{
    public class MapContinental: Map
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

        public override void Generate()
        {
            //_genertor.CreateMap<(typeof(T))>();
            
            SetMapNoise<PrelinNoise>();
            
            MeshRenderer rend = transform.GetComponent<MeshRenderer>();
            MeshFilter filt = transform.GetComponent<MeshFilter>();
            
            filt.mesh =  HandlerObject.CreateMesh(_width, _length); 
            
            Material mat = HandlerResource.GetMaterial("Unlit");

            
            Texture2D texture = HandlerTexture.CreateTexture(_width, _length, _noise);
            rend.sharedMaterial.mainTexture = texture;

        
        
        }
    
    
    }
}