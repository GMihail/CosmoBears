using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
public class Outline : MonoBehaviour
{
    [SerializeField] private Material[] _materials;
    [SerializeField] private Material _outline;
    private MeshRenderer mesh;
  
    private void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        _materials = new Material[mesh.materials.Length + 1];
        _materials[0] = mesh.materials[0];
    }
    private void SetOutline(Material mat)
    {
        _materials[_materials.Length - 1] = mat;
        mesh.materials = _materials;
    }

    public void Show()
    {
        SetOutline(_outline);
    }
    public void Hide()
    {
        SetOutline(mesh.materials[0]);
    }
}
