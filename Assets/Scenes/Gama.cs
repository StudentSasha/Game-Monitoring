using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gama : MonoBehaviour
{
  


    public void GameStart()
    {
        SceneManager.LoadScene("Gama");
    }
    public void StopScene()
    {
        SceneManager.LoadScene("StopGama");
       
    }

    public void GamaFinish()
    {
        SceneManager.LoadScene("GamaFinish");
    }
}
