using UnityEngine;

public static class Noise
{
  
    public static float [,] CreateNoiseMap(Vector2Int size, float scale)
    {

        int width = size.x;
        int height = size.y;
        
        if (scale <=0)
            scale = 0.0001f;

        float[,] noiseMap = new float[size.x,size.y];
        
        for (int y = 0; y < height; y++)
            for (int x = 0; x < width; x++)
            {
                float xScl = x / scale;
                float yScl = y / scale;
                float perlinPoint = Mathf.PerlinNoise(xScl, yScl);
                noiseMap[x,y] = perlinPoint;
            }
        
        return noiseMap;
    }





}
