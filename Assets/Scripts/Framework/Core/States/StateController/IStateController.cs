using UnityEngine;

namespace Core
{
    public interface IStateController: IController
    {
        T SetState<T>(string name = "State: Custom", GameObject obj = null, GameObject parent = null) where T: SceneObject, IState, new();

    }
}