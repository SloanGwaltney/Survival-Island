using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    [SerializeField] private PrefabReference projectileToSpawn;
    [SerializeField] private FloatReference projectileFireForce;
    [SerializeField] private Camera cam;
    // Called with unity events
    public void FireProjectile()
    {
        Vector3 cameraCenter = cam.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 1));
        GameObject projectile = Instantiate<GameObject>(projectileToSpawn.Value, cameraCenter, transform.rotation);
        Rigidbody rigidbody = projectile.GetComponent<Rigidbody>();
        if (!rigidbody) Debug.Log("A gun fired a bullet without a rigidbody");
        rigidbody?.AddForce(transform.forward * projectileFireForce.Value, ForceMode.Force);
    }
}
