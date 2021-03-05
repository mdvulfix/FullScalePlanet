using System;
using UnityEngine;
using Core;
using Core.Noise;
using Handlers;

namespace Source.Map
{
    public class Map: SceneObject//, IMap
    {
        //[SerializeField] protected GameObject   _obj;
        [SerializeField] protected string       _name;
        [SerializeField] protected int          _width;
        [SerializeField] protected int          _length;
        [SerializeField] protected float        _scale;
        [SerializeField] protected float[,]     _noise;

        protected IMapGenerator _genertor;

        public virtual void Awake()
        {
            
            SetParametrs(massege: "Map base parametrs were set");
            transform.gameObject.name = _name;
            
            Messenger.Send("Map was initialized");

        }

        public virtual void Generate()
        {
            //_genertor.CreateMap<(typeof(T))>();
            
            SetMapNoise<PrelinNoise>();
            MeshRenderer mapRend = transform.gameObject.AddComponent<MeshRenderer>();
            Texture2D texture = HandlerTexture.CreateTexture(_width, _length, _noise);
            mapRend.sharedMaterial.mainTexture = texture;

        
        
        }

        public virtual void SetMapNoise<T>(string massege = null) where T: INoise, new()
        {
            INoise noise = new T() as INoise;
            _noise = noise.GetNoiseMap(_width, _length, _scale);
            
        
            if(massege != null)
                Messenger.Send(massege);
        }

        public void SetParametrs(int width = 1, int length = 1, float scale = 5f, GameObject obj = null, string massege = null)
        {
            if (_name ==null)
                _name = "Map: Default";
            
            _width = width;
            _length = length;
            _scale = scale;
            _noise = new float[width, length];
            //_obj = obj;

            if(massege != null)
                Messenger.Send(massege);

        }
    
    }
}
