using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    private bool isPaused = false;

    public  void Update()
    {
        // Проверка нажатия кнопки "Пауза" (например, клавиша "P")
        if (Input.GetKeyDown(KeyCode.P))
        {
            TogglePause();
        }

        if (Input.GetKeyDown(KeyCode.S)) // Используйте любую клавишу или кнопку, которую вы хотите для паузы
        {
            if (!isPaused)
            {
                Time.timeScale = 0;
                isPaused = true;
            } else
            {
                Time.timeScale = 1;
                isPaused = false;
            }
            if (isPaused)
            {
                Time.timeScale = 1; // Возобновляем игру
            } else
            {
                Time.timeScale = 0; // Приостанавливаем игру
            }

            isPaused = !isPaused; // Инвертируем состояние паузы
        }
        
    }

    public void TogglePause()
    {
        isPaused = !isPaused;

        if (isPaused)
        {
            // Остановите игру
            Time.timeScale = 0;
            // Другие действия, связанные с паузой (отображение меню паузы, скрытие курсора и т. д.)
        } else
        {
            // Возобновите игру
            Time.timeScale = 1;
            // Другие действия при возобновлении игры
        }
    }
        
   
       

}







