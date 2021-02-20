using System;
using UnityEngine;
namespace Core.Controllers
{
    
    [Serializable]
    public abstract class AController: ASceneObject 
    {
        public override void Awake()
        {
            
            Messenger.Send("Map controller was initialized");

        }


    }
}