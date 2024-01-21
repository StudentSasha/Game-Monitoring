using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundControllerFinish : MonoBehaviour
{
    [SerializeField] private AudioSource SoundWin;
    [SerializeField] private AudioSource SoundApplause;

  
    private void OnApplicationPause(bool isPaused)
    {
        if (isPaused)
        {
            SoundWin.Stop();
            SoundApplause.Stop();
        } else
        {
            SoundWin.Play();
            SoundApplause.Play();
        }
    }
}
