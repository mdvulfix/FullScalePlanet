using System.Collections.Generic;
using UnityEngine;
using Core.Structs;

namespace Handlers
{
    public static class ObjectHandler
    {
        
        public static GameObject CreateObject(string name = "Custom object", string parent = "Scene")
        {          
            
            GameObject obj = new GameObject(name);
            obj.transform.parent = GameObject.Find(parent).transform;

            return obj;
        }  

        public static GameObject CreateObject(string name = "Custom object", Transform parent = null)
        {          
            
            GameObject obj = new GameObject(name);
            if(parent !=null)
                obj.transform.parent = parent;
            return obj;
        }         
        




        public static void AddMeshRenderer(GameObject obj)
        {
            MeshRenderer meshRenderer = obj.AddComponent<MeshRenderer>();
            meshRenderer.sharedMaterial = new Material(Shader.Find("Standard"));
        }
        
        public static void AddMeshFilter(GameObject obj, Mesh mesh)
        {
            MeshFilter meshFilter = obj.AddComponent<MeshFilter>();
            meshFilter.mesh = mesh;
        }

        public static Mesh CreateMesh(int width = 1, int length = 1, string name = "custom mesh")
        {
            Mesh mesh = new Mesh();
            mesh.name = name;
            
            List<Vector3> vList = new List<Vector3>();
            for(int z = 0; z < width + 1; z++ )
                for(int x = 0; x < length + 1; x++)
                    vList.Add(new Vector3(x, 0, z));

            mesh.vertices = vList.ToArray();

            
            List<Triangle> triangles = new List<Triangle>();
            for(int z = 0; z < width; z++)
                for(int x = 0; x < length; x++)
                {
                    triangles.Add(new Triangle((z + 0) * (length + 1) + x, (z + 1) * (length + 1) + x, (z + 1) * (length + 1) + x + 1));
                    triangles.Add(new Triangle((z + 0) * (length + 1) + x, (z + 1) * (length + 1) + x + 1, (z + 0) * (length + 1) + x + 1));
                }
            
            List<int> tList = new List<int>();
            for(int i = 0; i < triangles.Count; i++)
            {
                tList.Add(triangles[i].x);
                tList.Add(triangles[i].y);
                tList.Add(triangles[i].z);
            }
            
            mesh.triangles = tList.ToArray();
            
            List<Vector2> uvList = new List<Vector2>();
            for(int y = 0; y < width + 1; y++ )
                for(int x = 0; x < length + 1; x++)
                    uvList.Add(new Vector2((float)x / length, (float)y / width));

            mesh.uv = uvList.ToArray();

            mesh.RecalculateBounds();
            mesh.RecalculateNormals();
            mesh.RecalculateTangents();

            return mesh;
        }
    }
}