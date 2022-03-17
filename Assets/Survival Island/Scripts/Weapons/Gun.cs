using UnityEngine;

[CreateAssetMenu(fileName = "Gun", menuName = "Survival Island/Gun", order = 0)]
public class Gun : Weapon
{
    [field: SerializeField] public GunActionType ActionType { get; protected set; }
    [field: SerializeField] public float RoundsInClip { get; protected set; }
    [field: SerializeField] public float ReloadTime { get; protected set; }
    [field: SerializeField] public GunAmmo AmmoType { get; protected set; }
    [field: SerializeField] public float ProjectileFireForce { get; protected set; }
    [field: SerializeField] public GameObject ProjectilePrefab { get; protected set; }
}
