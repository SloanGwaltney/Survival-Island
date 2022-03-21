using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Weapon", menuName = "Survival Island/Weapon", order = 0)]
public class Weapon : ScriptableObject
{
    [field: SerializeField] public GameObject Prefab { get; protected set; }
    [field: SerializeField] public string Name { get; protected set; }
    [field: SerializeField] public string Description { get; protected set; }
}