using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DamageReceiver : MonoBehaviour
{
    public UnityEvent<float> DamageTaken;

    public void TakeDamage(float damageToTake)
    {
        DamageTaken.Invoke(damageToTake);
    }
}
