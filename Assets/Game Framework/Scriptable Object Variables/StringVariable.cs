using UnityEngine;

[CreateAssetMenu(fileName = "String Variable", menuName = "Game Framework/String Variable", order = 0)]
public class StringVariable : ScriptableObject
{
    [field: SerializeField] public string Value { get; private set; }
}