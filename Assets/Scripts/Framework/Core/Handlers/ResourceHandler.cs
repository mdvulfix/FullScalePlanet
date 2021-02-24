﻿using System;
using UnityEngine;
using Core;

namespace Core.Handlers
{
    public static class ResourceHandler
    { 
        
        private static string _path = "Materials/";

        public static Material GetMaterial(string name)
        {
            
            string fullpath = _path + name;
            
            Material resource = Resources.Load(fullpath, typeof(Material)) as Material;
            if(resource==null)
            {
                Messenger.Send("Material not found");
                return null;
            }
                
            
            
            return resource;
        }
    }
}