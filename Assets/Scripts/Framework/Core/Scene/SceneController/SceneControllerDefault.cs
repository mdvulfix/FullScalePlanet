using System.Collections.Generic;
using UnityEngine;
using Core;

public class SceneControllerDefault : SceneController, ISceneController
{

   public ISession                  Session     {get => _session; protected set => _session = value as Session;}
   
   public string                    ActiveScene {get => _activeScene; protected set => _activeScene = value;}
   public Dictionary<int, string>   Storage     {get => _storage; protected set => _storage = value;}
   
   
   private void OnInitialize() 
   {



   }


   
   
   public override void NextScene(string name)
   {


   }

}

