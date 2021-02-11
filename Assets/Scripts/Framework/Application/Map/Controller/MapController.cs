using Core;
using Core.Controllers;


namespace Application.Map
{
    

    public class MapController: AController
    {
        
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
           MapGenerator.Create<MapContinental>(10, 10);

       }
       
        /*
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
        */
    }
}
