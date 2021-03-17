using System;
using UnityEngine;

namespace Core
{

    [Serializable]
    public class DataMove: Data<Move>
    {
        
        public Vector3  Direction   {get; private set;}
        public int      Speed       {get; private set;}
            
        public DataMove()
        {
            Direction = Vector3.one;
            Speed = 10;
        }

        public DataMove(int speed)
        {
            Direction = Vector3.one;
            Speed = speed;
            

        }
    
        public void SetDirection(Vector3 direction)
        {
            Direction = direction;           

        }
    
    
    
    
    }
}
