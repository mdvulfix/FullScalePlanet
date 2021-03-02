using UnityEngine;
using UnityEngine.SceneManagement;

namespace Handlers
{
    public static class SceneHandler
    {
        
        public static void SetScene(string name = null, int index = 0)
        {          
            if(name != null)
                SceneManager.LoadSceneAsync(name);
            else   
                SceneManager.LoadSceneAsync(index);


        }  

        public static void CloseScene(string name = null, int index = 0)
        {          
            if(name != null)
                SceneManager.UnloadSceneAsync(name);
            else   
                SceneManager.UnloadSceneAsync(index);


        }  

    
        
    }
}