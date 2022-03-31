using System.Collections.Generic;
using UnityEngine;

public class Gatherable : MonoBehaviour
{
    [SerializeField] private List<PrefabReference> lootDrops;
    [SerializeField] private IntReference timesGatherable;
    [SerializeField] private PrefabGameEvent lootGathered;
    private int timesGathered;

    public void Gather()
    {
        timesGathered++;
        lootDrops.ForEach((prefabRef) => lootGathered.Raise(prefabRef.Value));
        if (timesGathered == timesGatherable.Value)
        {
            Destroy(this.gameObject);
        }
    }
    // Start is called before the first frame update
    private void Start()
    {
        timesGathered = 0;
    }
}
