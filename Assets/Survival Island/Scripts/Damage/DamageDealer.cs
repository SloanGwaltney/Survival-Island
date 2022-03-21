using UnityEngine;

public class DamageDealer : MonoBehaviour
{
    public void DealDamage(float amount, DamageReceiver objectToDamage)
    {
        objectToDamage.TakeDamage(amount);
    }
}
