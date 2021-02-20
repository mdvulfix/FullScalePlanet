using System;
using UnityEngine;

namespace Core
{
    [Serializable]
    public abstract class ASceneObject : MonoBehaviour 
    {
        public ASceneObject()
        {


        }

        public abstract void Awake();


    }
}