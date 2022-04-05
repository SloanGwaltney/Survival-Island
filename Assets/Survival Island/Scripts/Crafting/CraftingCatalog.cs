using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Crafting Catalog", menuName = "Survival Island/Crafting Catalog", order = 0)]
public class CraftingCatalog : ScriptableObject
{
    // If we need to get the game object for any reason we can grab it from the component
    // This is a very basic way will prob need to change up as I add filters, sorts etc...
    private List<CraftingRecipe> craftableObjects;

    private void OnEnable()
    {
        craftableObjects = new List<CraftingRecipe>();
        LoadResources();
    }

    // Might need to manage how this is loaded if prefab folder gets thick
    protected void LoadResources()
    {
        GameObject[] objects = Resources.LoadAll<GameObject>("/Prefabs");
        foreach (var obj in objects)
        {
            CraftingRecipe recipe = obj.GetComponent<CraftingRecipe>();
            if (recipe != null) craftableObjects.Add(recipe);
        }
    }

    public void RegisterObject(CraftingRecipe recipe)
    {
        craftableObjects.Add(recipe);
    }
}
