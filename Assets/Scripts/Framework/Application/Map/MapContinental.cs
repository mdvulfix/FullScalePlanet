using UnityEngine;
using Core.Handlers;
using Core.Scene;


namespace Application.Map
{
    public class MapContinental: AMap, IMap, IScene
    {
        public string Name{get; protected set;} = "Map: Сontinental";
        
        public int Width{get; protected set;}
        public int Length{get; protected set;} 
        
        public MapContinental()
        {
            

        }

        public void SetParametrs(int width = 1, int length = 1, string name = null)
        {
            
            Width = width;
            Length = length;
            if(name != null)
                Name = name;

        }
        
        
        public void SetGameObject(GameObject obj = null)
        {
            if(obj!= null)
            {
                Obj = obj;
                Obj.name = Name;
            }
            else   
                Obj = SceneObjectHandler.CreateObject(Name);
                
        }
        


    }
}