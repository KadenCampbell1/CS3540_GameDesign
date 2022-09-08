using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HideInstructions : MonoBehaviour
{
    public Text text;

    private void OnTriggerEnter(Collider other)
    {
        text.text = "Protect and guide the blue box to the blue area.";
    }

    private void OnTriggerExit(Collider other)
    {
        text.text = "";
    }
}
