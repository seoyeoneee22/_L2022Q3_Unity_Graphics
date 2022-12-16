using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pyramid : MonoBehaviour
{
    Vector3 V0, V1, V2, V3, V4;
    Vector3[] newVertices;
    int[] newTriangles;

    Vector3 N0, N1, N2, N3, N4;
    Vector3[] newNormals;

    void Start()
    {

            V0 = new Vector3(0, 0, -1);
            V1 = new Vector3(0, 0, 0);
            V2 = new Vector3(1, 0, 0);
            V3 = new Vector3(1, 0, -1);
            V4 = new Vector3(0.5f, 1, -0.5f);
          

            newVertices = new Vector3[]
            {
            V0, V1, V2, V3, V4
            };



            newTriangles = new int[]
            {
            0, 2, 1,
            0, 3, 2,
            0, 4, 3,
            3, 4, 2,
            2, 4, 1,
            1, 4, 0
            };

            N0 = Vector3.left + Vector3.back;
            N1 = Vector3.left + Vector3.forward;
            N2 = Vector3.right + Vector3.forward;
            N3 = Vector3.right + Vector3.back;
            N4 = Vector3.up;

        newNormals = new Vector3[]
        {
                N0,N1,N2,N3,N4
        };

            gameObject.AddComponent<MeshFilter>();
            gameObject.AddComponent<MeshRenderer>();
            Mesh mesh = new Mesh();
            GetComponent<MeshFilter>().mesh = mesh;
            mesh.vertices = newVertices;
            mesh.triangles = newTriangles;
        mesh.normals = newNormals;

            Shader DefaultShader = Shader.Find("Standard");
            Material DefaultMaterial = new Material(DefaultShader);
            gameObject.GetComponent<Renderer>().material = DefaultMaterial;
            }


        }

