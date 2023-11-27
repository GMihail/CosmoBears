using UnityEngine;
using UnityEngine.UI;

public class PlayerStatistic : MonoBehaviour
{
    [SerializeField] private float _health;
    [SerializeField] private Slider _hpSlider;

    private void Start()
    {
        _hpSlider.minValue = 0;
        _hpSlider.maxValue = _health;
        _hpSlider.value = _health;
    }

    private void Update()
    {
        _hpSlider.value = _health;
    }

    public void TakeDamage(float value)
    {
        if(value <= 0) return;
        _health -= value;
    }
    public void AddHealth(float value)
    {
        if (value <= 0) return;
       _health += value;
    }
    
}
