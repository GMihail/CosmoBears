using System.Collections;
using System.Collections.Generic;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AllFunctions : MonoBehaviour
{
    public float _force;
    public float _radius;
    public float _offsetY;
    public int _startTime;
    private bool _defuse = false;
    public Transform _door;
    public Slider _openSlider;
    public TMP_Text _timerText;
    private void Start()
    {
        _door = GetComponent<Transform>();
        _openSlider.minValue = _door.position.y;
        _openSlider.maxValue = _door.position.y + _offsetY;
    }

    public void StartTimer()
    {
        _timerText = GameObject.Find("TimerText").GetComponent<TMP_Text>();
        StartCoroutine(ITimer());
    }
    public void Defuse()
    { 
        _defuse = true;
    }
    private IEnumerator ITimer()
    {
        while (true) 
        {
            _startTime -= 1;
            if (_defuse == true)
            {
                break;
            }
            else if (_startTime == -1)
            {
                break;
            }
            _timerText.text =  _startTime.ToString();
            yield return new WaitForSeconds(1);
        }
    }
    public void DoorOpenClose()
    {
        _door.position = new Vector3(transform.position.x, _openSlider.value, transform.position.z);
    }
    public void Exploid()
    {
        Collider[] overLappedColiders = Physics.OverlapSphere(transform.position, _radius);
        for (int i = 0; i < overLappedColiders.Length; i++)
        {
            Rigidbody rigidbody = overLappedColiders[i].attachedRigidbody;
            if (rigidbody)
            {
                rigidbody.AddExplosionForce(_force, transform.position, _radius);
            }
        }
    }
    public void TimerUpdateButton(int value)
    {
        var _timerInt = int.Parse(_timerText.text);
        var summ = _timerInt + value;
        _timerText.text = summ.ToString();
    }
    
}
