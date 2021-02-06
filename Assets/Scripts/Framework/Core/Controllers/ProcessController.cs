using UnityEngine;
using Core.Controllers;
using Core.Handlers;

namespace Core.Processors
{
    public class ProcessController: AController
    {

        private GameObject _initialize;
        private GameObject _load;
        
        
        public override void Awake()
        {

            Initializing();
            Loading();

        }

        private void Initializing()
        {
            Messenger.Send("Initializing...");
            _initialize = SceneObjectHandler.CreateObject("Initializing", transform.name);
            _initialize.AddComponent<Initializing>();
        
            Messenger.Send("Initializing finished");
        } 

        private void Loading()
        {
            Messenger.Send("Loading...");
            _load = SceneObjectHandler.CreateObject("Loading", transform.name);
            _load.AddComponent<Loading>();
        
        
            Messenger.Send("Loading finished");
        } 


    }
}

