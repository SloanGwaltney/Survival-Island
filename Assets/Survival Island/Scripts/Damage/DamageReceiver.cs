using UnityEngine;
using UnityEngine.Events;

public class DamageReceiver : MonoBehaviour
{
    public UnityEvent<float> DamageTaken;

    public void TakeDamage(float damageToTake)
    {
        // not much here but if we ever wanted to de-buff damage with armor or something else that logic could go here
        Debug.Log("I make it to takedamage");
        DamageTaken.Invoke(damageToTake);
    }
}
