using UnityEngine;
using Core;

namespace Handlers
{
    public static class HandlerComponent
    {

        public static T GetComponent<T>(string name = "Component", GameObject obj = null, GameObject parent = null) where T: Core.Component, new()
        {
            
            T component;
            
            if(obj!=null)
            {
                component = obj.AddComponent<T>();
            }
            else
            {
                var newObj = HandlerObject.CreateObject(name, parent.transform);
                component = newObj.AddComponent<T>();
            }
            
            return component;
        }
        
        



    }
}