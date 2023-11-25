using UnityEngine;

public class CubeTriggers : MonoBehaviour
{
    private string name;
    private const string ENERGY = "energy";
    private const string BATTERY = "battery";
    private const string MASS = "mass";

    public void SetIndex(string name)
    {
        this.name = name;
    }

    private void Update()
    {
        switch (name)
        {
            case ENERGY:
                break;
            case BATTERY:
                break;
            case MASS:
                break;
        }
    }

}
