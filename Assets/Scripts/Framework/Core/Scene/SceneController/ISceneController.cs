using UnityEngine;

namespace Core
{
    public interface ISceneController: IController
    {
        T SetSceneHolder<T>(string name = "SceneHolder: Custom", GameObject obj = null, GameObject parent = null) where T: SceneObject, ISceneHolder, new();
        
    }
}