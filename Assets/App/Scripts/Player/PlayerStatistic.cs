using UnityEngine;
using UnityEngine.UI;

public class PlayerStatistic : MonoBehaviour
{
    [SerializeField] private float _power;
    [SerializeField] private Slider _powerSlider;

    public float Power { get => _power; set => _power = value; }

    private void Start()
    {
        _powerSlider.minValue = 0;
        _powerSlider.maxValue = Power;
        _powerSlider.value = Power;
    }

    private void Update()
    {
        _powerSlider.value = Power;
    }

    public void TakePower(float value)
    {
        if(Power < 0) return;
        if(value <= 0) return;
        Power -= value;
    }
    public void AddPower(float value)
    {
        if (value <= 0) return;
       Power += value;
    }
    
}
