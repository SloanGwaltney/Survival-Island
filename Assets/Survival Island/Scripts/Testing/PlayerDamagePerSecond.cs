using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// TESTING ONLY CLASS
public class PlayerDamagePerSecond : MonoBehaviour
{
    [SerializeField] private float damagePerSecond;
    private Health playerHealth;

    private void Start()
    {
        playerHealth = GetComponent<Health>();
    }
    // Update is called once per frame
    private void Update()
    {
        playerHealth.LoseHealth(damagePerSecond * Time.deltaTime);
    }
}
