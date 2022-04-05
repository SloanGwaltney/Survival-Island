using UnityEngine;

[System.Serializable]
public class CraftingRecipeItem
{
    [field: SerializeField] public GameObject Item { get; protected set; }
    [field: SerializeField] public float Quantity { get; protected set; }

    public CraftingRecipeItem(GameObject item, float quantity)
    {
        Item = item;
        Quantity = quantity;
    }
}
