using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu]
public class LoseData : ScriptableObject
{
    public void Lose()
    {
        SceneManager.LoadScene("LoseScene");
    }
}

