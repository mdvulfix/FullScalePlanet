using UnityEngine;
using Core.Handlers;


namespace Core
{   
    public class SceneObject : MonoBehaviour 
    {
        
        public GameObject Obj{get; set;}


        public SceneObject()
        {
            Obj = SceneObjectHandler.CreateObject("New object");
            


        }

        public SceneObject(GameObject obj)
        {
            Obj = obj;

        
        }





    }



}