using UnityEngine;

public class Energy : MonoBehaviour
{
    [SerializeField] private float _energy;
    [SerializeField] private string _name;
    public float Power
    {
        get { return _energy; }
        set { _energy = value; }
    }
    public string Name
    {
        get => _name;
    }
    private void Update()
    {
        if(_energy < 0)
        {
            _energy = 0;
        }
    }
}
