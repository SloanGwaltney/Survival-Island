using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Player Inventory", menuName = "Survival Island/Player Inventory", order = 0)]
public class PlayerInventory : ScriptableObject
{
    // So that designers can test with various equipment at loadtime
    [SerializeField] private List<InventorySlot> editorInventory;
    private Dictionary<string, InventorySlot> inventory;


    private void OnEnable()
    {
        inventory = new Dictionary<string, InventorySlot>();
        if (editorInventory != null)
        {
            editorInventory.ForEach((item) => inventory.Add(item.InventoryObject.Prefab.GetComponent<ObjectIdentifier>().Name.Value, item));
        }
    }

    public void AddItem(GameObject obj)
    {
        ObjectIdentifier itemIdentifer = obj.GetComponent<ObjectIdentifier>();
        string itemName = itemIdentifer.Name.Value;
        InventorySlot slot = new InventorySlot();
        Debug.Log(itemName);
        var didReturnVal = inventory.TryGetValue(itemName, out slot);
        if (didReturnVal)
        {
            slot.AddQuantity();
            return;
        }
        InventoriableObject iObj = new InventoriableObject(itemName, itemIdentifer.Description.Value, obj);
        InventorySlot newSlot = new InventorySlot(iObj);
        inventory.Add(itemName, newSlot);
    }
}