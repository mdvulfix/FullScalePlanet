using UnityEngine;
namespace Core.Handlers
{
    public class SpriteHandler: AHandler
    { 
        
        public Texture2D CreateTexture(GameObject obj, int width, int length, Color[] colorMap)
        {
            MeshRenderer meshRenderer =  obj.GetComponent<MeshRenderer>(); 

            Texture2D texture = new Texture2D(width, length);
            texture.SetPixels(colorMap);
            texture.Apply();
        
            meshRenderer.sharedMaterial.mainTexture = texture;
            meshRenderer.transform.localScale = new Vector3(width, 1, length);
            
            return texture;
        }
    }
}