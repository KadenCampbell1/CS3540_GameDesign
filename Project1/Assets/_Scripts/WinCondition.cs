using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCondition : MonoBehaviour
{
    public GameObject gameObject;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == gameObject)
        {
            SceneManager.LoadScene("WinScene");
        }
    }
}
