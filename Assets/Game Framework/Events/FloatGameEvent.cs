using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Float Game Event", menuName = "Game Framework/Float Game Event", order = 0)]
public class FloatGameEvent : ScriptableObject
{
    private List<FloatGameEventListener> eventListeners = new List<FloatGameEventListener>();

    public void Raise(float arg)
    {
        for (int i = eventListeners.Count - 1; i >= 0; i--)
        {
            eventListeners[i].OnEventRaised(arg);
        }
    }

    public void RegisterListener(FloatGameEventListener listener)
    {
        eventListeners.Add(listener);
    }

    public void UnregisterListener(FloatGameEventListener listener)
    {
        eventListeners.Remove(listener);
    }
}
