using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZipMesh : MonoBehaviour
{
    public float _width = 40f;
    public float _height = 100f;

    private void Start()
    {
        MeshFilter _mF = GetComponent<MeshFilter>();
        Mesh _zipMesh = new Mesh();
        _mF.mesh = _zipMesh;

        // Peaks
        Vector3[] vert = new Vector3[4]
        {
            new Vector3 (0, 0, 0), new Vector3 (_width, 0, 0), new Vector3 (0, _height, 0), new Vector3 (_width, _height, 0)
        };

        // Triangle
        int[] _triAngle = new int[6];
        {
            _triAngle[0] = 0;
            _triAngle[1] = 2;
            _triAngle[2] = 1;

            _triAngle[3] = 2;
            _triAngle[4] = 3;
            _triAngle[5] = 1;
        };

        // Textoures

    }
}
