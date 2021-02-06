using UnityEngine;
using Core.Handlers;

namespace Game.Map
{
    public class Map
    {
    
        private GameObject _obj;
        private int _width;
        private int _length;
        

        private float[,] _noiseMap;
        private Color[] _colorMap;
        private Texture2D _texture;
        
        public Map(GameObject obj, int width = 1, int length = 1)
        {
            _obj = obj;
            _width = width;
            _length = length;
        }

        public void SetNoiseMap()
        {
            PrelinNoise noise = new PrelinNoise();
            _noiseMap = noise.Get(_width, _length);
        }

        public void SetColorMap()
        {        
            ColorMap colorMap = new ColorMap();
            _colorMap = colorMap.Get(_width, _length, _noiseMap);
        
        }

        public void SetTexture()
        {        
            
            SpriteHandler sprHandler = new SpriteHandler();
            _texture = sprHandler.CreateTexture(_obj, _width, _length, _colorMap);
        
        }


    }
}
