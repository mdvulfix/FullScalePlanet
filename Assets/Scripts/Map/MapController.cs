using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class MapController
{
    public static Map _map;
    public static Vector2Int _mapSize;
    
    public static void CreateMap()
    {
        
        GameObject obj = SceneHandler.CreateObject("Map", new Vector2Int(10,10));
        _map = new Map(obj);

    
    }



}
