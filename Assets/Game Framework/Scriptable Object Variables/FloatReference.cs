using UnityEngine;

[System.Serializable]
public class FloatReference
{
    // all must be public with no getter/setter so that unity prop drawer can read :(
    public bool UseConstant;
    public float ConstantValue;
    public FloatVariable Variable;

    public float Value
    {
        get
        {
            return UseConstant ? ConstantValue : Variable.Value;
        }
    }
}
