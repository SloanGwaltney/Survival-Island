using UnityEngine;

// Ideally this would be a interface but that does not serialize well with unity
public class InventoriableObject
{

    public InventoriableObject(string name, string description, GameObject prefab)
    {
        Name = name;
        Description = description;
        Prefab = prefab;
    }

    public string Name { get; protected set; }
    public string Description { get; protected set; }
    public GameObject Prefab { get; protected set; }
}