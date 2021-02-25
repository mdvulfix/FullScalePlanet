using System;
using UnityEngine;

namespace Core
{
    [Serializable]
    public class State: SceneObject, IState
    {
        
        [SerializeField] protected string _stateName;  
        
        public State()
        {


        }




    }
}