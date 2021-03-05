using System.Collections.Generic;
using UnityEngine;
using Core;

public class ControlSceneDefault : ControlScene
{
   public string                    ActiveScene {get => _activeScene; protected set => _activeScene = value;}
   public Dictionary<int, string>   Storage     {get => _storage; protected set => _storage = value;}
   
   
   public ControlSceneDefault(ISession session) : base(session)
   {


   }


}

