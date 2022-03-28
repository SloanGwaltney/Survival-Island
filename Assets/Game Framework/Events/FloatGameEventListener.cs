using UnityEngine;
using UnityEngine.Events;

public class FloatGameEventListener : MonoBehaviour
{
    [SerializeField] private FloatGameEvent gameEvent;
    [SerializeField] private UnityEvent<float> response;

    public void OnEventRaised(float arg)
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
