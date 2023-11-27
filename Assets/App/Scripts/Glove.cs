using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Glove : MonoBehaviour
{
    [SerializeField] private float _distance;
    [SerializeField] private LayerMask _layerMask;
    [SerializeField] private List<GlovesInteract> _glovesInteracts;
    [SerializeField] private PhysicsGunInteractionBehavior _gravityGun;
    [SerializeField] private GameObject _light;
    [SerializeField] private Transform _spawnPosition;
    [SerializeField] private GameObject _prefab;

    public enum Modes
    {
        GravityGun = 0,
        Light = 1
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

          
        }
        
    }

}
