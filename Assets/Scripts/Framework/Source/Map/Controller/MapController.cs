using UnityEngine;
using Core;
using Core.Controllers;
using Core.Noise;
using Core.Handlers;


namespace Source.Map
{
    
    //[ExecuteInEditMode]
    public class MapController: AController
    {
        
        public int Width = 50; 
        public int Length = 50;
        public int Scale = 5;
        
        public bool autoUpdate;
        
        
        public override void Awake()
        {
            Messenger.Send("Map controller initialization...");

        }

        public void Start()
        {
            
            CreateMap();
        }
        
       
       public void CreateMap()
       {
            MapGenerator.Create<MapContinental>(Width, Length, Scale);
            //float[,] noiseMap = TextureHandler.GetNoiseMap<PrelinNoise>(Width, Length, scale);
            
            //PrelinNoise noise = new PrelinNoise();
            //float[,] noiseMap = noise.GetNoiseMap(Width, Length, scale);
            //MapDisplay display = FindObjectOfType<MapDisplay>();
            //display.DrawNoiseMap (noiseMap);
       }
    }
}
