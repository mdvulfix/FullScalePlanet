using UnityEngine;

namespace Core
{
    public class SceneObject : MonoBehaviour 
    {
        
        private GameObject _obj;
    
        public GameObject Obj {get => _obj; protected set => _obj = value as GameObject;} 
        
        public SceneObject()
        {

            
        }

        private void Awake() 
        {
            Obj = transform.gameObject;
            
        }


    }
}