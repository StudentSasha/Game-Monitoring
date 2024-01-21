using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseWindow : MonoBehaviour
{
    [SerializeField] private AudioSource SoundLost;
    [SerializeField] private AudioSource StartTheGame;
    public void Window()
    {
        SceneManager.LoadScene("Gama");
        //SoundLost.Play();
        //StartTheGame.Play();
    }
    private void OnApplicationPause(bool isPaused)
    {
        if (isPaused)
        {
            SoundLost.Stop();
            StartTheGame.Stop();
        } else
        {
            SoundLost.Play();
            StartTheGame.Play();
        }
    }

}
