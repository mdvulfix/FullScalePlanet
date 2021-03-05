using UnityEngine;
namespace Core.Noise
{
    public class PrelinNoise: Noise  
    {
        
        
        public override float [,] GetNoiseMap(int width, int height, float scale = 5f)
        {       
            if (scale <=0)
                scale = 0.0001f;

            float[, ] noiseMap = new float[width,height];
            
            for (int y = 0; y < height; y++)
                for (int x = 0; x < width; x++)
                {
                    noiseMap[x,y] = Mathf.PerlinNoise(x/scale, y/scale);
                }

            
            return noiseMap;
        }
    }
}