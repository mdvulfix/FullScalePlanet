using System;
using UnityEngine;
using Core;
using Handlers;

public abstract class SceneController : SceneObject, ISceneController
{
   private Session _session;             

   
   public ISession Session {get => _session; protected set => _session = value as Session;}

   public virtual void SetSession(ISession session)
   {
         Session = session as Session;

   }

      public virtual T SetSceneHolder<T>(string name = "SceneHolder: Custom", GameObject obj = null, GameObject parent = null) where T: SceneObject, ISceneHolder, new()
      {
      var sceneHolder = ComponentHandler.SetComponent<T>(name, obj, parent);
      return sceneHolder;

      }
}

