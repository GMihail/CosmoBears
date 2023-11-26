using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerBomb : MonoBehaviour
{
    [SerializeField] private float timeLeft;
    [SerializeField] public Explosion _explode;
    [SerializeField] public Explosion _bool;
    public bool _active;
    private void Start()
    {
        _active = _bool._activate;
    }
    public void TimerActivate()
    {
        while(_active)
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            _explode.BombExplode();
            _bool._activate = false;
        }
    }
}
