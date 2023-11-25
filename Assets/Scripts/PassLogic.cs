using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassLogic : MonoBehaviour
{
    [SerializeField]
    private GameObject _unlockvariants;

    [SerializeField]
    private GameObject _cyberpanel;
    [SerializeField]
    private GameObject _passcode;

    public void CyberHack()
    {
        _cyberpanel.SetActive(true);
        _unlockvariants.SetActive(false);
    }
    public void Pass()
    {
        _passcode.SetActive(true);
        _unlockvariants.SetActive(false);
    }
}
