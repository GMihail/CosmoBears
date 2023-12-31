using UnityEngine;
using UnityEngine.Events;

public class InteractableObject : MonoBehaviour
{
    [SerializeField] private UnityEvent _useEvent;
    [SerializeField] private Animator _animation;
    public Animator Animation
    {
        get
        {
            return _animation;
        }
    }
   
    public UnityEvent EventBtn
    {
        get
        {
            return _useEvent;
        }
    }
}
