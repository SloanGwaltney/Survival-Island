using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Float Variable", menuName = "Game Framework/Float Variable", order = 0)]
public class FloatVariable : ScriptableObject
{
    [field: SerializeField] public float Value { get; private set; }
}
