using UnityEngine;

namespace Core
{
    public class SceneObject : MonoBehaviour 
    {
        public GameObject Obj {get => _obj; protected set => _obj = value as GameObject;} 
        
        
        private GameObject _obj;
        
        
        public SceneObject()
        {

            
        }

        private void Awake() 
        {
            Obj = transform.gameObject;
            
            
        }


    }
}