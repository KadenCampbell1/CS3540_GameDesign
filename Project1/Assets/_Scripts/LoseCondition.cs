using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseCondition : MonoBehaviour
{
    public bool hasLost = false;
    
    void Update()
    {
        if (hasLost)
        {
            SceneManager.LoadScene("LoseScene");
        }
    }
}
