using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kursi : MonoBehaviour
{
    [SerializeField]
    public Material cubeMaterial;

    void Start()
    {
        Mesh mesh = new Mesh();
        var vertices = new Vector3[42];
        var uvs = new Vector2[vertices.Length];
        Texture myTexture;

        //load texture
        myTexture = Resources.Load<Texture>("Textures/textures");
        //set texture to material
        cubeMaterial.mainTexture = myTexture;

        vertices[0] = new Vector3(-2.0f, -4.5f, -2.5f);
        vertices[1] = new Vector3(-1.5f, -4.5f, -2.5f);
        vertices[2] = new Vector3(-1.5f, -4.5f, -2.0f);
        vertices[3] = new Vector3(-2.0f, -4.5f, -2.0f);
        vertices[4] = new Vector3(-1.5f, -1.0f, -2.5f);
        vertices[5] = new Vector3(-1.5f, -1.0f, -2.0f);
        vertices[6] = new Vector3(-2.0f, -1.0f, -2.0f);
        vertices[7] = new Vector3(-2.0f, -1.0f, -2.5f);
        vertices[8] = new Vector3(1.5f, -4.5f, -2.5f);
        vertices[9] = new Vector3(2.0f, -4.5f, -2.5f);
        vertices[10] = new Vector3(2.0f, -4.5f, -2.0f);
        vertices[11] = new Vector3(1.5f, -4.5f, -2.0f);
        vertices[12] = new Vector3(2.0f, -1.0f, -2.0f);
        vertices[13] = new Vector3(2.0f, -1.0f, -2.5f);
        vertices[14] = new Vector3(1.5f, -1.0f, -2.0f);
        vertices[15] = new Vector3(1.5f, -1.0f, -2.5f); //depan

        uvs[0] = new Vector2(0.5f, 0.5f);
        uvs[1] = new Vector2(0.75f, 0.5f);
        uvs[2] = new Vector2(0.5f, 1.0f);
        uvs[3] = new Vector2(0.75f, 1.0f);
        uvs[4] = new Vector2(0.5f, 0.5f);
        uvs[5] = new Vector2(0.75f, 0.5f);
        uvs[6] = new Vector2(0.5f, 1.0f);
        uvs[7] = new Vector2(0.75f, 1.0f);
        uvs[8] = new Vector2(0.5f, 0.5f);
        uvs[9] = new Vector2(0.75f, 0.5f);
        uvs[10] = new Vector2(0.5f, 1.0f);
        uvs[11] = new Vector2(0.75f, 1.0f);
        uvs[12] = new Vector2(0.75f, 0.5f);
        uvs[13] = new Vector2(0.5f, 1.0f);
        uvs[14] = new Vector2(0.75f, 1.0f);
        uvs[15] = new Vector2(0.75f, 1.0f);




        vertices[16] = new Vector3(1.5f, -4.5f, 2.5f);
        vertices[17] = new Vector3(2.0f, -4.5f, 2.5f);
        vertices[18] = new Vector3(2.0f, -4.5f, 3.0f);
        vertices[19] = new Vector3(1.5f, -4.5f, 3.0f);
        vertices[20] = new Vector3(2.0f, -1.0f, 3.0f);
        vertices[21] = new Vector3(1.5f, -1.0f, 3.0f);
        vertices[22] = new Vector3(1.5f, -1.0f, 2.5f);
        vertices[23] = new Vector3(2.0f, -1.0f, 2.5f);
        vertices[24] = new Vector3(-2.0f, -4.5f, 2.5f);
        vertices[25] = new Vector3(-1.5f, -4.5f, 2.5f);
        vertices[26] = new Vector3(-1.5f, -4.5f, 3.0f);
        vertices[27] = new Vector3(-2.0f, -4.5f, 3.0f);
        vertices[28] = new Vector3(-1.5f, -1.0f, 2.5f);
        vertices[29] = new Vector3(-1.5f, -1.0f, 3.0f);
        vertices[30] = new Vector3(-2.0f, -1.0f, 3.0f); //belakang
        vertices[31] = new Vector3(-2.0f, -1.0f, 2.5f);


        uvs[16] = new Vector2(0.5f, 0.5f);
        uvs[17] = new Vector2(0.75f, 0.5f);
        uvs[18] = new Vector2(0.5f, 1.0f);
        uvs[19] = new Vector2(0.75f, 1.0f);
        uvs[20] = new Vector2(0.5f, 0.5f);
        uvs[21] = new Vector2(0.75f, 0.5f);
        uvs[22] = new Vector2(0.5f, 1.0f);
        uvs[23] = new Vector2(0.75f, 1.0f);
        uvs[24] = new Vector2(0.5f, 0.5f);
        uvs[25] = new Vector2(0.75f, 0.5f);
        uvs[26] = new Vector2(0.5f, 1.0f);
        uvs[27] = new Vector2(0.75f, 1.0f);
        uvs[28] = new Vector2(0.75f, 0.5f);
        uvs[29] = new Vector2(0.5f, 1.0f);
        uvs[30] = new Vector2(0.75f, 1.0f);
        uvs[31] = new Vector2(0.75f, 1.0f);




        vertices[32] = new Vector3(-2.0f, 0.0f, -2.5f);
        vertices[33] = new Vector3(2.0f, 0.0f, -2.5f);
        vertices[34] = new Vector3(2.0f, 0.0f, 3.0f);
        vertices[35] = new Vector3(-2.0f, 0.0f, 3.0f); //alas

        uvs[32] = new Vector2(0.5f, 0.5f);
        uvs[33] = new Vector2(0.75f, 0.5f);
        uvs[34] = new Vector2(0.5f, 1.0f);
        uvs[35] = new Vector2(0.75f, 1.0f);


        vertices[36] = new Vector3(-2.0f, 0.0f, 2.5f);
        vertices[37] = new Vector3(2.0f, 0.0f, 2.5f);
        vertices[38] = new Vector3(-2.0f, 6.0f, 2.5f);
        vertices[39] = new Vector3(-2.0f, 6.0f, 3.0f);
        vertices[40] = new Vector3(2.0f, 6.0f, 3.0f);
        vertices[41] = new Vector3(2.0f, 6.0f, 2.5f); //senderan

        
        uvs[36] = new Vector2(0.5f, 0.5f);
        uvs[37] = new Vector2(0.75f, 0.5f);
        uvs[38] = new Vector2(0.5f, 1.0f);
        uvs[39] = new Vector2(0.75f, 1.0f);
        uvs[40] = new Vector2(0.5f, 1.0f);
        uvs[41] = new Vector2(0.75f, 1.0f);

        mesh.vertices = vertices;

        mesh.uv = uvs;

        mesh.triangles = new int[]
        {
            0,4,1,
            0,7,4,
            1,4,5,
            1,5,2,
            2,5,3,
            3,5,6,
            3,6,0,
            0,6,7,
            3,0,1,
            1,2,3,
            6,5,4,
            7,6,4, //kaki depan kiri
        	8,15,13,
            8,13,9, //depan
        	9,13,12,
            9,12,10, //kanan
        	10,12,11,
            11,12,14, //belakang
        	11,14,8,
            8,14,15, //kiri
        	8,9,11,
            9,10,11, //bawah
        	15,14,13,
            14,12,13, //kaki depan kanan
        	16,22,23,
            16,23,17,
            17,23,20,
            17,20,18,
            18,20,19,
            19,20,21,
            19,21,16,
            16,21,22,
            16,17,19,
            17,18,19,
            22,21,23,
            21,20,23, //kaki belakang kanan
        	24,31,28,
            24,28,25,
            25,28,29,
            25,29,26,
            26,29,27,
            27,29,30,
            27,30,24,
            24,30,31,
            24,25,27,
            25,26,27,
            31,30,28,
            30,29,28, //kaki belakang kiri
        	7,32,33,
            7,33,13,
            13,33,34,
            13,34,20,
            20,34,30,
            30,34,35,
            30,35,7,
            7,35,32,
            7,13,30,
            13,20,30,
            32,35,33,
            35,34,33, //alas
        	36,38,41,
            36,41,37,
            37,41,40,
            37,40,34,
            34,40,35,
            35,40,39,
            35,39,36,
            36,39,38,
            36,37,35,
            37,34,35,
            38,39,41,
            39,40,41 //senderan



        };
        mesh.RecalculateNormals();
        GetComponent<MeshFilter>().mesh = mesh;
        GetComponent<MeshRenderer>().material = cubeMaterial;

    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
       /* float cubeTime = Time.fixedTime;
        if (cubeTime % 1.0f == 0)
        {
            var mesh = GetComponent<MeshFilter>().mesh;
            var length = mesh.vertices.Length;
            Color32[] colors = new Color32[length];
            for (int i = 0; i < length; i++)
            {
                byte valueR = (byte)(Random.Range(0.0f, 1.0f) * 255);
                byte valueG = (byte)(Random.Range(0.0f, 1.0f) * 255);
                byte valueB = (byte)(Random.Range(0.0f, 1.0f) * 255);
                colors[i] = new Color32(valueR, valueG, valueB, 255);
            }
            mesh.colors32 = colors;
        }*/
    }
}
