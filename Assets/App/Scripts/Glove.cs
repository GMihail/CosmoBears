using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Glove : MonoBehaviour
{
    [SerializeField] private UnityEvent _glovesEvents;
    [SerializeField] private float _distance;
    [SerializeField] private LayerMask _layerMask;
    [SerializeField] private List<GlovesInteract> _glovesInteracts;
    [SerializeField] private PhysicsGunInteractionBehavior _gravityGun;
    [SerializeField] private GameObject _light;
    public enum Modes
    {
        GravityGun = 0,
        Energy = 1,
        Light = 2
    }

    public Modes _mode;
    private void Start()
    {
        foreach (GlovesInteract item in FindObjectsOfType<GlovesInteract>())
        {
            _glovesInteracts.Add(item);
        }
    }

    
        
    private void Update()
    {
        if (ThirdPersonShooterController.Instance.IsAiming)
        {
            if (Input.GetMouseButtonDown(0)){
                Vector3 mousWordPos = Vector3.zero;
                Vector2 screenCenterPoint = new Vector2(Screen.width / 2f, Screen.height / 2);
                Ray ray = Camera.main.ScreenPointToRay(screenCenterPoint);
                if (Physics.Raycast(ray, out RaycastHit raycastHit, _distance, _layerMask))
                {
                    if (raycastHit.collider.TryGetComponent(out GlovesInteract interact))
                    {
                       
                    }
                }
            }

            if (_mode == Modes.GravityGun)
            {
                _gravityGun.enabled = true;
            }
            else
            {
                _gravityGun.enabled = false;
            }


            if (_mode == Modes.Light)
            {
                _gravityGun.enabled = false;
                _light.SetActive(true);
            }
            else
            {
                _light.SetActive(false);
            }


            foreach (GlovesInteract outline in _glovesInteracts)
            {
                outline.GetComponent<Outline>().Show();
            }
        }
        else
        {
            foreach (GlovesInteract outline in _glovesInteracts)
            {
                outline.GetComponent<Outline>().Hide();
            }

            if (_mode == Modes.GravityGun)
            {
                _gravityGun.enabled = false;
            }
            if (_mode == Modes.Light)
            {
                _light.SetActive(false);
            }
        }
        
    }

}
