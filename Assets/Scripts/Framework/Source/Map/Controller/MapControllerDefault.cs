using System;
using UnityEngine;
using Core;
using Handlers;


namespace Source.Map
{
    
    public class MapControllerDefault: IMapController
    {
        private IMapGenerator _generator;
        
        /*
        public void Start()
        {
            SetMapGenerator<MapGeneratorDefault>("Map generator was initialized");
            CreateMap();
        
        }

        public void CreateMap()
        {
            _generator.SetParametrs(10, 10, 2f);
            _generator.CreateMap<MapContinental>();
        }

        
        public void SetMapGenerator<T>(string massege = null) where T: ASceneObject, IMapGenerator
        {
            string objName = "Custom generator";
            GameObject genObj = SceneObjectHandler.CreateObject(objName, transform);
            _generator = genObj.AddComponent<T>();
    
            if(massege != null)
                Messenger.Send(massege);
            
        }
        */
    }
}
