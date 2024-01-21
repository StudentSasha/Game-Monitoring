using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    [SerializeField] private GameObject MenuButton;
    [SerializeField] private GameObject MenuWindow;
    [SerializeField] private AudioSource SoundOwl;
    [SerializeField] private AudioSource SoundDyatel;
    [SerializeField] private AudioSource SoundPtizi;
    [SerializeField] private GameObject Player;

    

    public GameObject prefabToDisable; // Ссылка на префаб, который вы хотите выключить при паузе

   



    public void OpenMenuWindow()
    {
        MenuButton.SetActive(false);
        MenuWindow.SetActive(true);
        SoundOwl.Stop();
        SoundDyatel.Stop();
        SoundPtizi.Stop();
        Player.SetActive(false);
       
        
        Time.timeScale = 0f; // Замораживаем время, чтобы пауза работала
        if (prefabToDisable != null)
        {
            prefabToDisable.SetActive(false); // Выключаем префаб при паузе
        }
        
    }

     
    public void CloseMenuWindow() {
        MenuButton.SetActive(true);
        MenuWindow.SetActive(false);
        SoundOwl.Play();
        SoundDyatel.Play();
        SoundPtizi.Play();
        Player.SetActive(true);

        
        
        Time.timeScale = 1f; // Восстанавливаем нормальное время после выхода из паузы
        if (prefabToDisable != null)
        {
            prefabToDisable.SetActive(true); // Включаем префаб после выхода из паузы
        }
        
    }

   

    public void Restart()
    {       
        SceneManager.LoadScene("Gama");

        
        Time.timeScale = 1f; // Восстанавливаем нормальное время после выхода из паузы
        if (prefabToDisable != null)
        {
            prefabToDisable.SetActive(true); // Включаем префаб после выхода из паузы
        }
    }

   
   
}

