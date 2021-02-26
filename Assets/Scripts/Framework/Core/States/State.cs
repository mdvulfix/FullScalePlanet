using System;
using UnityEngine;

namespace Core
{
    [Serializable]
    public abstract class State: SceneObject, IState
    {
        
        [SerializeField] protected string _stateName;  
        
        public State()
        {


        }




    }
}