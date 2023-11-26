using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AllFunctions : MonoBehaviour
{
    public float _force;
    public float _radius;
    public float _offsetY;
    public Transform _door;
    public Slider _openSlider;
    public Text _timerText;
    private void Start()
    {
        _door = GetComponent<Transform>();
        _openSlider.minValue = _door.position.y;
        _openSlider.maxValue = _door.position.y + _offsetY;
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
    //public void TimerUpdateButton(int value)
    //{
     //   var _timerInt = int.Parse(_timerText.text);
       // var summ = _timerInt + value;
        //_timerText.text = summ.ToString();
    //}
}
