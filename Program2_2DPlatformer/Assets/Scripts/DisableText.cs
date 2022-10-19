using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableText : MonoBehaviour
{
    public float hold_time = 3;
    // Start is called before the first frame update
    private IEnumerator Start()
    {
        yield return new WaitForSeconds(hold_time);
        gameObject.SetActive(false);
    }
    
}
