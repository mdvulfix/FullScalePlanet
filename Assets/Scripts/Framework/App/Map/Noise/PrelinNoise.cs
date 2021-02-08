using UnityEngine;
namespace Game.Map
{
    public class PrelinNoise: ANoise
    {
        public override float [,] Get(int width, int height, float scale = 1)
        {       
            if (scale <=0)
                scale = 0.0001f;

            noise = new float[width,height];
            
            for (int y = 0; y < height; y++)
                for (int x = 0; x < width; x++)
                    noise[x,y] = Mathf.PerlinNoise(x/scale, y/scale);

            
            return noise;
        }
    }
}