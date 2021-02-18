using UnityEngine;
using Core.Noise;
using Core.Handlers;

namespace Application.Map
{
    public static class MapGenerator
    {
        public static void Create<T>(int width = 1, int length = 1, string name = null) where T: MonoBehaviour, IMap, new()
        {
           
            GameObject objMap = GetObject(width, length);
            float[,] noiseMap = GetNoiseMap<PrelinNoise>(width, length);
            Texture2D texture = GetTexture(width, length, noiseMap);


            
            IMap map = objMap.AddComponent<T>();
            
            map.SetParametrs(width, length);
            map.SetGameObject(objMap);


            //return map;
        }



        private static GameObject GetObject(int width = 1, int length = 1, string name = "custom mesh")
        {
            GameObject obj = SceneObjectHandler.CreateObject();
            MeshRenderer meshRenderer = obj.AddComponent<MeshRenderer>();
            MeshFilter meshFilter = obj.AddComponent<MeshFilter>();
            
            meshFilter.mesh =  SceneObjectHandler.CreateMesh(width, length, name); 
            return obj;
        }

        private static float[,] GetNoiseMap<T>(int width, int length, int scale = 1) where T: INoise, new()
        {
            
            T noise = new T();
            float[,] noiseMap = noise.GetNoiseMap(width, length, scale);
            return noiseMap;
        }

        private static Texture2D GetTexture(int width, int length, float[,] noiseMap)
        {
            Texture2D texture = SpriteHandler.CreateTexture(width, length, noiseMap);
            return texture;
        }


    }

}