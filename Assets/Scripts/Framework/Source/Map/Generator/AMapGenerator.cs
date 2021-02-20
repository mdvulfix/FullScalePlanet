using System;
using UnityEngine;
using Core;
using Core.Noise;

namespace Source.Map 
{
    [Serializable]
    public abstract class AMapGenerator : ASceneObject
    {
        [SerializeField] protected string   _name;

        [SerializeField] protected int      _mapWidth;
        [SerializeField] protected int      _mapLength;
        [SerializeField] protected float    _mapScale;
        [SerializeField] protected float[,] _mapNoise;

        public override void Awake()
        {
            
            
            SetParametrs(massege: "Parametrs were set");
            transform.gameObject.name = _name;
            
            Messenger.Send("Map controller was initialized");

        }

        public virtual void SetParametrs(int width = 1, int length = 1, float scale = 5f, string massege = null)
        {
            _name = "Map: Generator";
            _mapWidth = width;
            _mapLength = length;
            _mapScale = scale;
            
            SetMapNoise<PrelinNoise>();

            if(massege != null)
                Messenger.Send(massege);

        }

        public abstract void CreateMap<T>(string massege) where T: ASceneObject, IMap, new();

        protected virtual void SetMapNoise<T>(string massege = null) where T: INoise, new()
        {
            INoise noise = new T() as INoise;
            _mapNoise = noise.GetNoiseMap(_mapWidth, _mapLength, _mapScale);
            
        
            if(massege != null)
                Messenger.Send(massege);
        }
    }
}