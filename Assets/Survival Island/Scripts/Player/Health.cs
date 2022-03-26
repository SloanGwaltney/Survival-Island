using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    [field: SerializeField] public FloatReference StartingHealth { get; set; }
    [SerializeField] private UnityEvent<float> HeathLostEvent;
    private float health;

    private void OnEnable()
    {
        health = StartingHealth.Value;
    }

    public void LoseHealth(float damageToHealth)
    {
        HeathLostEvent?.Invoke(damageToHealth);
        health -= Mathf.Clamp(damageToHealth, 0, health);
        // testing
        if (health == 0f)
        {
        }
    }
}
