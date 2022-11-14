using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class IntData : ScriptableObject
{
    public int value, lessThanValue, greaterThanValue;
    public UnityEvent lessThanEvent, greaterThanEvent;

    public void SetValue(int obj)
    {
        value = obj;
    }

    public void IncrementValue(int obj)
    {
        value += obj;

        if (value >= greaterThanValue)
        {
            greaterThanEvent.Invoke();
        }

        if (value <= 0.0001f && value >= -0.0001f)
        {
            value = 0;
        }

        if (value <= lessThanValue)
        {
            lessThanEvent.Invoke();
        }
    }
}