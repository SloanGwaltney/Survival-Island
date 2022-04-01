using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Prefab Game Event", menuName = "Game Framework/Prefab Game Event", order = 0)]
public class PrefabGameEvent : ScriptableObject
{
    private List<PrefabGameEventListener> eventListeners = new List<PrefabGameEventListener>();

    public void Raise(GameObject arg)
    {
        for (int i = eventListeners.Count - 1; i >= 0; i--)
        {
            eventListeners[i].OnEventRaised(arg);
        }
    }

    public void RegisterListener(PrefabGameEventListener listener)
    {
        eventListeners.Add(listener);
    }

    public void UnregisterListener(PrefabGameEventListener listener)
    {
        eventListeners.Remove(listener);
    }
}