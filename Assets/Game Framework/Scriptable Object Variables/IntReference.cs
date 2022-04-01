using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class IntReference
{
    // all must be public with no getter/setter so that unity prop drawer can read :(
    public bool UseConstant;
    public int ConstantValue;
    public IntVariable Variable;

    public int Value
    {
        get
        {
            return UseConstant ? ConstantValue : Variable.Value;
        }
    }
}
