using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPlatform : MonoBehaviour
{
    public Rigidbody _rb;
    public float _range = 1f;
    public float _jumpAmount = 35;
    public bool _grounded = false;
    public Camera _camera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ShootRayCast();
        if (Input.GetKeyDown(KeyCode.Space) & _grounded == true)
        {
            _rb.AddForce(Vector3.up * _jumpAmount, ForceMode.Impulse);
        }
    }
    private void ShootRayCast()
    {
        RaycastHit hit;
        if (Physics.Raycast(_camera.transform.position, _camera.transform.forward, out hit, _range))
        {
            Debug.Log(hit.transform.name);
            Target target = hit.transform.GetComponent<Target>();
            if(target != null)
            {
                StartCoroutine(JumpBool());
            }
        }
    }
    IEnumerator JumpBool()
    {
        _grounded = true;
        yield return new WaitForSeconds(0.5f);
        _grounded = false;
    }
}
