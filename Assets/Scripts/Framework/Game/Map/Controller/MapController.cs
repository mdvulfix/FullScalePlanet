using UnityEngine;
using Core;
using Core.Controllers;
using Core.Handlers;

namespace Game.Map
{
    

    public class MapController: AController
    {
        public Map _map;
        public int Width;
        public int Length;
        
        public override void Awake()
        {
            Messenger.Send("Map controller initialization...");
        }
        
        
        public void CreateMap()
        {
            GameObject obj = SceneObjectHandler.CreateObject("Map");
            SceneObjectHandler.AddMeshRenderer(obj);
            Mesh mesh = SceneObjectHandler.CreateMesh("Сustom", 10, 10);
            SceneObjectHandler.AddMeshFilter(obj, mesh);

            _map = new Map(obj, Width, Length);
            _map.SetNoiseMap();
            _map.SetColorMap();
            _map.SetTexture();

        }
    }
}
