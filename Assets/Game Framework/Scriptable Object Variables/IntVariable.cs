using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Int Variable", menuName = "Game Framework/Int Variable", order = 0)]
public class IntVariable : ScriptableObject
{
    [field: SerializeField] public int Value { get; private set; }
}
