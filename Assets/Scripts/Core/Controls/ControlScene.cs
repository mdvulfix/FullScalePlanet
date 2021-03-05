using System.Collections.Generic;
using UnityEngine;
using Core;
using Handlers;

public abstract class ControlScene : SceneObject, IControlScene
{
   protected Session                      _session;
   protected Dictionary<int, string>      _storage;

   [SerializeField] protected string      _activeScene;              

   
   
#region Session

   public virtual void SetSession(ISession session)
   {
         _session = session as Session;

   }

#endregion

#region Storage

      public virtual T SetSceneStorage<T>(string name = "SceneHolder: Custom", GameObject obj = null, GameObject parent = null) where T: SceneObject, IStorageScene, new()
      {
            var sceneHolder = HandlerComponent.SetComponent<T>(name, obj, parent);
            return sceneHolder;

      }

#endregion

#region SceneManagement

      public virtual void LoadScene(string name)
      {
            HandlerScene.SetScene(name: name);

      }

      public virtual void LoadScene(int index)
      {
            HandlerScene.SetScene(index: index);

      }
      
      public virtual void CloseScene(string name)
      {
            HandlerScene.CloseScene(name: name);

      }

      public virtual void CloseScene(int index)
      {
            HandlerScene.CloseScene(index: index);

      }

      public virtual string SetActiveScene(string name)
      {
            _activeScene = name;
            return name;
      }
      
      
      public virtual void NextScene(string name)
      {
            CloseScene(_activeScene);
            LoadScene(name); 
            _activeScene = name;

      }



#endregion




}

