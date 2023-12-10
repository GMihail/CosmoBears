using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Explosion : MonoBehaviour
{
    public float _force;
    public float _radius;
    public bool _activate;

    public void Activate()
    {
        BombExplode();
    }
    public void BombExplode()
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
}