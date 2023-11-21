using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
public class Outline : MonoBehaviour
{
    private void Start()
    {
        //Material[] materials = new Material[]
        //    {
        //        Resources.Load("Materials/Outline") as Material,
        //    };
        this.GetComponent<MeshRenderer>().materials[0] = Resources.Load("Materials/Outline") as Material;
    }
}
