using UnityEngine;
using Cinemachine;
using StarterAssets;

public class ThirdPersonShooterController : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera _aimVirtualCamera;
    [SerializeField] private float _nomalSensitivity;
    [SerializeField] private float _aimSensitivity;
    [SerializeField] private LayerMask AimLayerMask;
    [SerializeField] private GameObject _crosshair;

    private StarterAssetsInputs starterAssetsInput;
    private ThirdPersonController thirdPersonController;


    private void Awake()
    {
        thirdPersonController = GetComponent<ThirdPersonController>();
        starterAssetsInput = GetComponent<StarterAssetsInputs>();
    }

    private void Update()
    {
        Vector3 mousWordPos = Vector3.zero;
        Vector2 screenCenterPoint = new Vector2(Screen.width / 2f, Screen.height / 2);

        Ray ray = Camera.main.ScreenPointToRay(screenCenterPoint);
        if(Physics.Raycast(ray,out RaycastHit raycastHit, 250f, AimLayerMask))
        {
            mousWordPos = raycastHit.point;
        }

        if (starterAssetsInput.aim)
        {
            _aimVirtualCamera.gameObject.SetActive(true);
            thirdPersonController.SetSensitivity(_aimSensitivity);
            thirdPersonController.SetRotation(false);

            Vector3 worldAimTarget = mousWordPos;
            worldAimTarget.y = transform.position.y;
            Vector3 aimDirection = (worldAimTarget - transform.position).normalized;

            transform.forward = Vector3.Lerp(transform.forward, aimDirection, Time.deltaTime * 20f);
            _crosshair.SetActive(true);
        }
        else
        {
            _crosshair.SetActive(false);
            _aimVirtualCamera.gameObject.SetActive(false);
            thirdPersonController.SetSensitivity(_nomalSensitivity);
            thirdPersonController.SetRotation(true);
        }
    }
}
