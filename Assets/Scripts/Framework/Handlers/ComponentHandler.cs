using UnityEngine;
using Core;

namespace Handlers
{
    public static class ComponentHandler
    {


        public static T AddController<T>(string name = "Controller", Transform parent = null) where T: SceneObject, IController, new()
        {
            GameObject obj = SceneObjectHandler.CreateObject(name, parent);
            var component = obj.AddComponent<T>();
            return component;
        }


    }
}