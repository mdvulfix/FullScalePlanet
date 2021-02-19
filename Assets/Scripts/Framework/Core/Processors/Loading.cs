using UnityEngine;
using Source.Map;

namespace Core.Processors
{
    public class Loading : AProcessor
    {

        public override void Awake()
        {
            LoadScreenDataImage();
            LoadMainMenu();
            
    
        }

        private void LoadScreenDataImage()
        {
            Messenger.Send("Screen data image loading...");

        }

        private void LoadMainMenu()
        {
            Messenger.Send("Main menu loading...");

        }




    }
}