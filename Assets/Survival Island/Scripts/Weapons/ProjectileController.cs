using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    [SerializeField] private PrefabReference projectileToSpawn;
    [SerializeField] private FloatReference projectileFireForce;
    // Called with unity events
    public void FireProjectile()
    {
        GameObject projectile = Instantiate<GameObject>(projectileToSpawn.Value, transform.forward, transform.rotation);
        Rigidbody rigidbody = projectile.GetComponent<Rigidbody>();
        if (!rigidbody) Debug.Log("A gun fired a bullet without a rigidbody");
        rigidbody?.AddForce(transform.forward * projectileFireForce.Value, ForceMode.Force);
    }
}
