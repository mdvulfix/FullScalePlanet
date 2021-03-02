using System.Collections.Generic;
using UnityEngine;

namespace Core
{

    public class SceneStorageDefault: SceneStorage
    {

        
        public string                   ActiveScene {get => _activeScene; protected set => _activeScene = value;}
        public Dictionary<int, string>  Storage     {get => _storage; protected set => _storage = value;}
        
        private void Awake() 
        {
            _storage.Add(0, "Core");
            _storage.Add(1, "Loading");
            _storage.Add(2, "MainMenu");
            _storage.Add(3, "Game");

            _sceneCount = Storage.Count;



        }


        


    }
}