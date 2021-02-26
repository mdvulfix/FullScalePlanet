using UnityEngine;
using Core;

namespace Handlers
{
    public static class ComponentHandler
    {

        public static T SetComponent<T>(string name = "Custom component", GameObject obj = null, GameObject parent = null) where T: SceneObject, new()
        {
            
            T component;
            
            if(obj!=null)
            {
                component = obj.AddComponent<T>();
            }
            else
            {
                var newObj = SceneObjectHandler.CreateObject(name, parent.transform);
                component = newObj.AddComponent<T>();
            }
            
            return component;
        }
        
        



    }
}