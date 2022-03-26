using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DamageOnOverlap : MonoBehaviour
{
    public UnityEvent<float, DamageReceiver> DamageOverlapEntered;
    public FloatReference damageToDeal;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject == gameObject) return;
        DamageReceiver receiver = other.gameObject.GetComponent<DamageReceiver>();
        if (!receiver) return;
        DamageOverlapEntered.Invoke(damageToDeal.Value, receiver);
    }
}
