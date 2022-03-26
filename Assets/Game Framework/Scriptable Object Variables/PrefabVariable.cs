using UnityEngine;

[CreateAssetMenu(fileName = "Prefab Variable", menuName = "Game Framework/Prefab Variable", order = 0)]
public class PrefabVariable : ScriptableObject
{
    [field: SerializeField] public GameObject Value { get; private set; }
}
