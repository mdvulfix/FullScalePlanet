using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public struct Triangle
{
    public int v1;
    public int v2;
    public int v3;

    public Triangle(int v1, int v2, int v3)
    {
        this.v1 = v1;
        this.v2 = v2;
        this.v3 = v3;
    }
}


public class SceneHandler : MonoBehaviour
{
    
    public GameObject plane;


    private void Start()
    {
        
        plane = CreateObject("Terrain");



    }

    
    private GameObject CreateObject(string name)
    {
        
        GameObject new_object = new GameObject(name);
        new_object.transform.SetParent(transform);
        MeshRenderer meshRenderer = new_object.AddComponent<MeshRenderer>();
        MeshFilter meshFilter = new_object.AddComponent<MeshFilter>();
        
        meshFilter.mesh = CreateMesh("Custom mesh", 10, 10);
        meshRenderer.sharedMaterial = new Material(Shader.Find("Standard"));
        
        return new_object;
    }


    private Mesh CreateMesh(string name, int length, int width)
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
            tList.Add(triangles[i].v1);
            tList.Add(triangles[i].v2);
            tList.Add(triangles[i].v3);
        }
        
        mesh.triangles = tList.ToArray();
        
        List<Vector2> uvList = new List<Vector2>();
        for(int y = 0; y < width + 1; y++ )
            for(int x = 0; x < length + 1; x++)
                uvList.Add(new Vector2((float)x / length, (float)y / width));

        mesh.uv = uvList.ToArray();

        mesh.RecalculateBounds();
        mesh.RecalculateNormals();
        //mesh.RecalculateTangents();    

    
        return mesh;

    }

}
