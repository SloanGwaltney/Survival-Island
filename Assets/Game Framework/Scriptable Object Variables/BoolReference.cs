[System.Serializable]
public class BoolReference
{
    // all must be public with no getter/setter so that unity prop drawer can read :(
    public bool UseConstant;
    public bool ConstantValue;
    public BoolReference Variable;

    public bool Value
    {
        get
        {
            return UseConstant ? ConstantValue : Variable.Value;
        }
    }
}
