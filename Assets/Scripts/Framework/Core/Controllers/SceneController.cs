using System;
using UnityEngine;
using Core;

public abstract class SceneController : SceneObject, IController
{
   [Header("Session"), SerializeField]
   private Session _session;             
        
   public ISession Session {get => _session; protected set => _session = value as Session;}

   public virtual void SetSession(ISession session)
   {
         Session = session as Session;

   }
}

