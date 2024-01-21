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
        // �������� ������� ������ "�����" (��������, ������� "P")
        if (Input.GetKeyDown(KeyCode.P))
        {
            TogglePause();
        }

        if (Input.GetKeyDown(KeyCode.S)) // ����������� ����� ������� ��� ������, ������� �� ������ ��� �����
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
                Time.timeScale = 1; // ������������ ����
            } else
            {
                Time.timeScale = 0; // ���������������� ����
            }

            isPaused = !isPaused; // ����������� ��������� �����
        }
        
    }

    public void TogglePause()
    {
        isPaused = !isPaused;

        if (isPaused)
        {
            // ���������� ����
            Time.timeScale = 0;
            // ������ ��������, ��������� � ������ (����������� ���� �����, ������� ������� � �. �.)
        } else
        {
            // ����������� ����
            Time.timeScale = 1;
            // ������ �������� ��� ������������� ����
        }
    }
        
   
       

}







