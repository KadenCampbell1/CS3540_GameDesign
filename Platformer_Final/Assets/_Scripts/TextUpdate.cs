using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextUpdate : MonoBehaviour
{
    public IntData data;
    public Text text;
    public string textValue = "Health: ";
    
    void Update()
    {
        text.text = textValue + data.value;
    }
}
