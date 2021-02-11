using UnityEngine;

namespace Core.Handlers
{
    public static class SpriteHandler
    { 
        
        public static Texture2D CreateTexture(int width, int length, float[,] noiseMap)
        {
            Texture2D texture = new Texture2D(width, length);
            Color[] colorMap = new Color[width * length];
            
            for (int y = 0; y < length; y++)
                for (int x = 0; x < width; x++)
                    colorMap[y * width + x] = Color.Lerp(Color.black, Color.white, noiseMap[x,y]);
            

            texture.SetPixels(colorMap);
            texture.Apply();
            
            return texture;
        }
    }
}