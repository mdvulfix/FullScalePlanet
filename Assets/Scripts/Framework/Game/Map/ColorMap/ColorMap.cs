using UnityEngine;

namespace Game.Map
{
    public class ColorMap
    {  
        public Color[] Get(int width, int height, float[,] noise)
        {       
            Color[] colorMap = new Color[width * height];
            
            for (int y = 0; y < height; y++)
                for (int x = 0; x < width; x++)
                colorMap[y * width + x] = Color.Lerp(Color.black, Color.white, noise[x,y]);

            return colorMap;
        }
    }
}