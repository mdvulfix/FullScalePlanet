
namespace Core
{
    public abstract class ASession : ASceneObject, ISession
    {
        
        
        public SceneController sceneController { get; private set; }
        public AudioController audioController { get; private set; }
        public CameraController cameraController { get; private set; }
        
        
        public override void Awake()
        {

            Messenger.Send("Session initialization..");
            SetControllers("Controllers were set!");
            
        
        
        
            Messenger.Send("Session has been initialized");
        }

        private void SetControllers(string message = null)
        {
            sceneController = SetSceneController();
            audioController = SetAudioController();
            cameraController = SetCameraController();

            if(message!=null)
                Messenger.Send(message);

        
        }

        protected abstract SceneController SetSceneController(string message = null);
        protected abstract AudioController SetAudioController(string message = null);
        protected abstract CameraController SetCameraController(string message = null);










    }
}
