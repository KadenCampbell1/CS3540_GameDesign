using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameCondition : MonoBehaviour
{
    public bool win;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == GameObject.FindGameObjectWithTag("Player"))
        {
            if (win)
            {
                WinGame();
            }
            else
            {
                LoseGame();
            }
        }
    }

    public void WinGame()
    {
        SceneManager.LoadScene("WinScene");
    }
    
    public void LoseGame()
    {
        SceneManager.LoadScene("LoseScene");
    }
}
