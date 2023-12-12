using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoPlay : MonoBehaviour
{
    public RawImage _backGround;
    public VideoPlayer _mainMenuBackGround;

    private void Start()
    {
        StartCoroutine(PlayVideo());
    }
    IEnumerator PlayVideo()
    {
        _mainMenuBackGround.Prepare();
        WaitForSeconds waitForSeconds =  new WaitForSeconds(1);
        while (!_mainMenuBackGround.isPrepared)
        {
            yield return waitForSeconds;
            break;
        }
        _backGround.texture = _mainMenuBackGround.texture;
        _mainMenuBackGround.Play();
    }
}
