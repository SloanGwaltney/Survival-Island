using UnityEngine;

[CreateAssetMenu(fileName = "Bool Variable", menuName = "Game Framework/Boolean Variable", order = 0)]
public class BoolVariable : ScriptableObject
{
    [field: SerializeField] public bool Value { get; private set; }
}
