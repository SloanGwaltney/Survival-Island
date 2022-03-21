using UnityEngine;

[CreateAssetMenu(fileName = "Gun Action Type", menuName = "Survival Island/Gun Action Type", order = 0)]
public class GunActionType : ScriptableObject
{
    [field: SerializeField] public string Name { get; protected set; }
    [field: SerializeField] public string Description { get; protected set; }
    [field: SerializeField] public float CycleTime {get; protected set;}
    [field: SerializeField] public bool IsAutomatic {get; protected set;}
    [field: SerializeField] public float RoundsPerShot {get; protected set;}
}
