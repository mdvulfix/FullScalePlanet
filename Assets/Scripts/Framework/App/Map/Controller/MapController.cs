using UnityEngine;
using Core;
using Core.Controllers;
using Core.Handlers;

namespace Game.Map
{
    

    public class MapController: AController
    {
        public Map _map;
        public int Width = 5;
        public int Length = 5;
        
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
            GameObject obj = SceneObjectHandler.CreateObject("Map");
            SceneObjectHandler.AddMeshRenderer(obj);
            Mesh mesh = SceneObjectHandler.CreateMesh("Сustom", Width, Length);
            SceneObjectHandler.AddMeshFilter(obj, mesh);

            _map = obj.AddComponent<Map>();
            _map._width = Width;
            _map._width = Length;
            //_map = new Map(obj, Width, Length);
            //_map.SetNoiseMap();
            //_map.SetColorMap();
            //_map.SetTexture();

        }
    }
}
