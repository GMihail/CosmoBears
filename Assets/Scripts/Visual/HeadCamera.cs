using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class HeadCamera : MonoBehaviour
{
    [SerializeField] private Transform _camera;
    [SerializeField] private float _minY;
    [SerializeField] private float _maxY;

    private void LateUpdate()
    {
        float mouseX = Input.GetAxis("MouseX");

        float clampedMouseX = Mathf.Clamp(mouseX, -1, 1);

        // Производим вращение головы
        transform.Rotate(Vector3.up, clampedMouseX);
    }
    private float WrapAngle(float angle)
    {
        angle %= 360;
        if (angle > 180)
            return angle - 360;

        return angle;
    }
    private float UnwrapAngle(float angle)
    {
        if (angle >= 0)
            return angle;

        angle = -angle % 360;

        return 360 - angle;
    }
    private void Update()
    {
    }
}
