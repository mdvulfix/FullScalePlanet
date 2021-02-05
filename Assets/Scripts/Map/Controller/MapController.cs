using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class MapController
{
    public static Map _map;
    public static int width;
    public static int length;
    
    public static void CreateMap()
    {
        
        GameObject obj = ObjectHandler.CreateObject("Map");
        ObjectHandler.AddMeshRenderer(obj);
        Mesh mesh = ObjectHandler.CreateMesh("Сustom", 10, 10);
        ObjectHandler.AddMeshFilter(obj, mesh);

        _map = new Map(obj, width, length);
        //_map.SetNoiseMap();
        //_map.SetColorMap();
        //_map.SetTexture();


    
    }



}
