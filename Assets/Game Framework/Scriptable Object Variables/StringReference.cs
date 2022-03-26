[System.Serializable]
public class StringReference
{
    // all must be public with no getter/setter so that unity prop drawer can read :(
    public bool UseConstant;
    public string ConstantValue;
    public StringVariable Variable;

    public string Value
    {
        get
        {
            return UseConstant ? ConstantValue : Variable.Value;
        }
    }
}