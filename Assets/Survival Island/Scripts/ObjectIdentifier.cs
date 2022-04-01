using UnityEngine;

// Can be used when passing game objects around in system to identify "what an object is" helpful
public class ObjectIdentifier : MonoBehaviour
{
    [field: SerializeField] public StringReference Name { get; private set; }
    [field: SerializeField] public StringReference Description { get; private set; }
}
