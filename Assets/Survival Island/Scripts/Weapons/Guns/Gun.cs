using UnityEngine;

[CreateAssetMenu(fileName = "Gun", menuName = "Survival Island/Gun", order = 0)]
public class Gun : Weapon
{
    [field: SerializeField] public GunActionType Action { get; protected set; }
    [field: SerializeField] public float RoundsPerClip { get; protected set; }
    [field: SerializeField] public float ReloadTime { get; protected set; }
    [field: SerializeField] public GunAmmo AmmoType { get; protected set; }
    [field: SerializeField] public float ProjectileFireForce { get; protected set; }
    [field: SerializeField] public GameObject ProjectilePrefab { get; protected set; }
}
