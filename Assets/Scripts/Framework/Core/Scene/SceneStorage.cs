using System;
using System.Collections.Generic;
using UnityEngine;


namespace Core
{
    [Serializable]
    public abstract class SceneStorage: SceneObject, ISceneStorage
    {
        
        protected Dictionary<int, string>   _storage;

        [SerializeField] protected int      _sceneCount;
        [SerializeField] protected string   _activeScene;     

        public SceneStorage()
        {
            _storage = new  Dictionary<int, string>();

        }


        public virtual void AddScene(int index, string name)
        {
            _storage.Add(index, name);

        }
    }
}