using UnityEngine;
using Core.Noise;

namespace Handlers
{
    public static class TextureHandler
    { 
        
        
        public static float[,] GetNoiseMap<T>(int width, int length, int scale = 1) where T: INoise, new()
        {
            
            T noise = new T();
            float[,] noiseMap = noise.GetNoiseMap(width, length, scale);
            return noiseMap;
        }
        
        
        
        
        
        public static Texture2D CreateTexture(int width, int length, float[,] noiseMap = null)
        {
            Texture2D texture = new Texture2D(width, length);
            Color[] colorMap = new Color[width * length];
            
            for (int y = 0; y < length; y++)
                for (int x = 0; x < width; x++)
                {
                    if(noiseMap !=null)
                        colorMap[y * width + x] = Color.Lerp(Color.black, Color.white, noiseMap[x,y]);
                    else
                        colorMap[y * width + x] = Color.yellow;
                }
            

            texture.SetPixels(colorMap);
            texture.Apply();
            
            return texture;
        }
    }
}