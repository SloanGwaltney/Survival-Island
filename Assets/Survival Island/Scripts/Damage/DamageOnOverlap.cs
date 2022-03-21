using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DamageOnOverlap : MonoBehaviour
{
    public UnityEvent<float, DamageReceiver> DamageOverlapEntered;
    [field: SerializeField] private float damageToDeal;

    private void OnCollisionEnter(Collision other) 
    {
        DamageReceiver receiver = other.gameObject.GetComponent<DamageReceiver>();
        DamageOverlapEntered.Invoke(damageToDeal, receiver);
    }
}
