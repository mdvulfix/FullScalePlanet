using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneHandler : MonoBehaviour
{
    
    public string objectName = "Plane";


    void Start()
    {
        
        CreatePlane(objectName);



    }


    void CreatePlane(string name)
    {
        CreateObject(name);
        CreateMesh();
        CreateTexture();




    }
    
    void CreateObject(string name)
    {
        GameObject plane = new GameObject(name);
        
    }


    void CreateMesh()
    {

        CreateMeshFilter();
        CreateMeshRenderer();
    
    }

    void CreateMeshFilter()
    {



    }
    void CreateMeshRenderer()
    {


    }


    void CreateTexture()
    {


    }

}
