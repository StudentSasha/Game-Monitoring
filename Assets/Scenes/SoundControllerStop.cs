using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundControllerStop : MonoBehaviour
{
    [SerializeField] private AudioSource _lost;
    [SerializeField] private AudioSource _lost1;
    


    private void OnApplicationPause(bool isPaused)
    {
        if(isPaused)
        {
            _lost.Stop();
            _lost1.Stop();
        } else
        {
            _lost.Play();
            _lost1.Play();
        }
    }

   

   
}
