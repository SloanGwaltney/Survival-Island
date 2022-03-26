using UnityEngine;

public class Health : MonoBehaviour
{
    [field: SerializeField] public FloatReference StartingHealth { get; set; }
    private float health;

    private void OnEnable()
    {
        health = StartingHealth.Value;
    }

    public void LoseHealth(float damageToHealth)
    {
        health -= Mathf.Clamp(damageToHealth, 0, health);
        Debug.Log("Health: " + health);
        // testing
        if (health == 0f)
        {
            Debug.Log("I died");
        }
    }
}
