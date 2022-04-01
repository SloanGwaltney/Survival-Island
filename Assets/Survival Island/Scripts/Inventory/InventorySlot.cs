using UnityEngine;

[System.Serializable]
public class InventorySlot
{
    [field: SerializeField] public InventoriableObject InventoryObject { get; private set; }
    [field: SerializeField] public float Quantity { get; private set; }

    public InventorySlot()
    {

    }
    public InventorySlot(InventoriableObject inventoriableObject, float quantity = 1f)
    {
        InventoryObject = inventoriableObject;
        Quantity = quantity;
    }
    public void AddQuantity()
    {
        Quantity++;
    }
}
