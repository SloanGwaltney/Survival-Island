using UnityEngine;

[System.Serializable]
public class PrefabReference
{
    // all must be public with no getter/setter so that unity prop drawer can read :(
    public bool UseConstant;
    public GameObject ConstantValue;
    public PrefabVariable Variable;

    public GameObject Value
    {
        get
        {
            return UseConstant ? ConstantValue : Variable.Value;
        }
    }
}