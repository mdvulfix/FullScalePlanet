using System.Collections.Generic;
using UnityEngine;
using Core;
using Handlers;

public abstract class ControlScene: IControlScene
{


      public ISession Session {get => _session; protected set => _session = value as Session;}
   
   
      protected static Dictionary<int, string>     _storage;

      
      private Session _session;    
      
      
      
      [SerializeField] protected static string     _activeScene;              

      protected ControlScene(ISession session)
      {
            SetSession(session);
      }
   
#region Session

   public virtual void SetSession(ISession session)
   {
         _session = session as Session;

   }

#endregion

#region Storage
      /*
      public static T SetSceneStorage<T>(string name = "SceneHolder: Custom", GameObject obj = null, GameObject parent = null) where T: SceneObject, IStorageScene, new()
      {
            var sceneHolder = HandlerComponent.SetComponent<T>(name, obj, parent);
            return sceneHolder;

      }
      */
#endregion

#region SceneManagement

      public static void LoadScene(string name)
      {
            HandlerScene.SetScene(name: name);

      }

      public static void LoadScene(int index)
      {
            HandlerScene.SetScene(index: index);

      }
      
      public static void CloseScene(string name)
      {
            HandlerScene.CloseScene(name: name);

      }

      public static void CloseScene(int index)
      {
            HandlerScene.CloseScene(index: index);

      }

      public static string SetActiveScene(string name)
      {
            _activeScene = name;
            return name;
      }
      
      
      public static void NextScene(string name)
      {
            CloseScene(_activeScene);
            LoadScene(name); 
            _activeScene = name;

      }



#endregion




}

