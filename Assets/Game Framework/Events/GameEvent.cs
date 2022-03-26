using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Game Event", menuName = "Game Framework/Game Event", order = 0)]
public class GameEvent : ScriptableObject
{
    private List<GameEventListener> eventListeners = new List<GameEventListener>();

    public void Raise()
    {
        for (int i = eventListeners.Count - 1; i >= 0; i--)
        {
            eventListeners[i].OnEventRaised();
        }
    }

    public void RegisterListener(GameEventListener listener)
    {
        eventListeners.Add(listener);
    }

    public void UnregisterListener(GameEventListener listener)
    {
        eventListeners.Remove(listener);
    }
}
