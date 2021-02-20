using UnityEngine;
using Core;
using Core.Noise;
using Core.Handlers;

namespace Source.Map
{
    public class MapGeneratorDefault: AMapGenerator, IMapGenerator
    {
        public int      MapWidth  {get  => _mapWidth;   set => _mapWidth = value;}
        public int      MapLength {get  => _mapLength;  set => _mapLength = value;}
        public float    MapScale  {get  => _mapScale;   set => _mapScale = value;}
        public float[,] MapNoise  {get  => _mapNoise;   set => _mapNoise = value;}
      
       
        public override void CreateMap<T>(string massege = null)
        {
                       
            GameObject mapObj       = SceneObjectHandler.CreateObject("Custom map",transform.parent);
            MeshRenderer mapRend    = mapObj.AddComponent<MeshRenderer>();
            MeshFilter mapFilt      = mapObj.AddComponent<MeshFilter>();
            
            mapFilt.mesh =  SceneObjectHandler.CreateMesh(_mapWidth, _mapLength); 
            
            Material mat = ResourceHandler.GetMaterial("Unlit");
            Texture2D texture = TextureHandler.CreateTexture(_mapWidth, _mapLength, _mapNoise);

            mat.mainTexture = texture;
            mapRend.sharedMaterial = mat;

            IMap map = mapObj.AddComponent<T>();
            map.SetParametrs(_mapWidth, _mapLength, _mapScale, mapObj, "Map custom parametrs were set");
        }

    }

}