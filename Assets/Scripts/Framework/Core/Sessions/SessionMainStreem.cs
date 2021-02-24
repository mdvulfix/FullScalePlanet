using UnityEngine;
using Core.Handlers;

namespace Core
{
    public class SessionMainStreem : ASession
    {


        protected override SceneController SetSceneController(string message = null)
        {
            
            var controller = ComponentHandler.AddController<SceneController>("SceneController");
            return controller;
        }

        protected override AudioController SetAudioController(string message = null)
        {
            AudioController controller = new AudioController();
            

            return controller;


        }

        protected override CameraController SetCameraController(string message = null)
        {
            CameraController controller = new CameraController();
            

            return controller;

        }
    
    
    
    
    }
}