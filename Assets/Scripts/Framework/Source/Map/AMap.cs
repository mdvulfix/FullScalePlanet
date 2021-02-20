using UnityEngine;
using Core;

namespace Source.Map
{
    public abstract class AMap: ASceneObject
    {
        //[SerializeField] protected GameObject   _obj;
        [SerializeField] protected string       _name;
        [SerializeField] protected int          _width;
        [SerializeField] protected int          _length;
        [SerializeField] protected float        _scale;
        [SerializeField] protected float[,]     _noise;


        
        
        public override void Awake()
        {
            
            SetParametrs(massege: "Map base parametrs were set");
            transform.gameObject.name = _name;
            
            Messenger.Send("Map was initialized");

        }
    
        public void SetParametrs(int width = 1, int length = 1, float scale = 5f, GameObject obj = null, string massege = null)
        {
            if (_name ==null)
                _name = "Map: Default";
            
            _width = width;
            _length = length;
            _scale = scale;
            _noise = new float[width, length];
            //_obj = obj;

            if(massege != null)
                Messenger.Send(massege);

        }
    
    }
}
