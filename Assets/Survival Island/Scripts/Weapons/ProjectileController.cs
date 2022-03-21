using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    // Called with unity events
    public void FireProjectile(Gun gun)
    {
        GameObject projectile = Instantiate<GameObject>(gun.ProjectilePrefab, transform.forward, transform.rotation);
        Rigidbody rigidbody = projectile.GetComponent<Rigidbody>();
        if (!rigidbody) Debug.Log("A gun fired a bullet without a rigidbody");
        rigidbody?.AddForce(transform.forward * gun.ProjectileFireForce, ForceMode.Force);
    }
}
