using UnityEngine;

namespace Core.Processors
{
    public class Initializing : AProcessor
    {

        public override void Awake()
        {
            InitializeCache();
        }

        public void InitializeCache()
        {
            Messenger.Send("Cache initializing...");

        }


    }
}

