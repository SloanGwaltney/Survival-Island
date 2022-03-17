using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Gun Ammo", menuName = "Survival Island/Gun Ammo", order = 0)]
public class GunAmmo : ScriptableObject
{
    [field: SerializeField] public string Name { get; protected set; }
    [field: SerializeField] public string Description { get; protected set; }
    [field: SerializeField] public GameObject Prefab { get; protected set; }
}
