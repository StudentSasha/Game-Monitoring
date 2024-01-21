using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinWindow : MonoBehaviour
{

    [SerializeField] private AudioSource SoundWin;
    [SerializeField] private AudioSource SoundApplause;

    public void Window()
    {
        SceneManager.LoadScene("Gama");
    }
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
