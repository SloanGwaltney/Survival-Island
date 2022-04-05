using System.Collections.Generic;
using UnityEngine;

public class CraftingRecipe : MonoBehaviour
{
    // TODO: Connect this via an event
    [field: SerializeField] private CraftingCatalog catalog;
    [field: SerializeField] public List<CraftingRecipeItem> Recipe { get; protected set; }

    private void OnEnable()
    {
        catalog.RegisterObject(this);
    }
}
