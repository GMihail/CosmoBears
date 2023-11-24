using UnityEngine;

public class Energy : MonoBehaviour
{
    [SerializeField] private float _energy;

    public float Power
    {
        get { return _energy; }
        set { _energy = value; }
    }

    private void Update()
    {
        if(_energy < 0)
        {
            _energy = 0;
        }
    }
}
