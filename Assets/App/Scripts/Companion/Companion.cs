using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Companion : MonoBehaviour
{
    [SerializeField] float lerpSpeed = 10f;
    [SerializeField] private Transform CompanionPlace;
    private Transform _companion;
    [SerializeField] private Animator _animator;
    [SerializeField] private ThirdPersonController thirdPersonController;
    private void Start()
    {
        _companion = GetComponent<Transform>();
    }

    void LateUpdate()
    {
        _companion.position = Vector3.Lerp(transform.position, CompanionPlace.position, Time.deltaTime * lerpSpeed);
    }
    private void Update()
    {
        _animator.SetFloat("move", thirdPersonController.GetAnimationBlend()/2f);
    }
}
