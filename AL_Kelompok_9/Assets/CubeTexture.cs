using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTexture : MonoBehaviour {
    public Vector3[] newVertices;
    public Vector2[] newUV;
    public int[] newTriangles;
    void Start() {
        Mesh mesh = new Mesh();
        mesh.vertices = newVertices;
        mesh.uv = newUV;
        mesh.triangles = newTriangles;
        GetComponent<MeshFilter>().mesh = mesh;
    }
}