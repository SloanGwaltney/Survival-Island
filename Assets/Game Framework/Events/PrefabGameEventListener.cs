using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PrefabGameEventListener : MonoBehaviour
{
    [SerializeField] private PrefabGameEvent gameEvent;
    [SerializeField] private UnityEvent<GameObject> response;

    public void OnEventRaised(GameObject arg)
    {
        response.Invoke(arg);
    }

    private void OnEnable()
    {
        gameEvent.RegisterListener(this);
    }

    private void OnDisable()
    {
        gameEvent.UnregisterListener(this);
    }
}