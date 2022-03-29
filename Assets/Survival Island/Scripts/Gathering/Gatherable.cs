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
        lootDrops.ForEach((prefabRef) => lootGathered.Raise(prefabRef.Value));
    }
    // Start is called before the first frame update
    private void Start()
    {
        timesGathered = 0;
    }
}
