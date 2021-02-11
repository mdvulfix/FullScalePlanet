using UnityEngine;
using Core.Noise;
using Core.Handlers;

namespace Application.Map
{
    public static class MapGenerator
    {
        public static void Create<T>(int width, int length) where T: IMap, new()
        {
           
            GameObject objMap = GetObject("Map");
            
            
            
            
            
            float[,] noiseMap = GetNoiseMap<PrelinNoise>(width, length);
            Texture2D texture = GetTexture(width, length, noiseMap);




            //return map;
        }
        private static GameObject GetObject(string name)
        {
            GameObject obj = SceneObjectHandler.CreateObject(name);
            
            
            
            
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