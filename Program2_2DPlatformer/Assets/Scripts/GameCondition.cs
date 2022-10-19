using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameCondition : MonoBehaviour
{
    public bool win;

    private void OnCollisionEnter2D(Collision2D col)
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

    public void WinGame()
    {
        SceneManager.LoadScene("WinScene");
    }
    
    public void LoseGame()
    {
        SceneManager.LoadScene("LoseScene");
    }
}
