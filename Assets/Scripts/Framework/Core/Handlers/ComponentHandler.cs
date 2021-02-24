using UnityEngine;
using Core;
using Core.Handlers;

public static class ComponentHandler
{


    public static T AddController<T>(string name) where T: ASceneObject, IController, new()
    {
        GameObject obj = SceneObjectHandler.CreateObject(name);
        var component = obj.AddComponent<T>();
        return component;
    }


}
