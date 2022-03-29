using UnityEngine;
using UnityEditor;

// Custom editor work to let the unity editor user raise an float event from the editor while the game is playing. Great for testing.
[CustomEditor(typeof(FloatGameEvent))]
public class FloatGameEventEditor : Editor
{
    private string floatInput;
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        GUI.enabled = Application.isPlaying;
        GUILayout.BeginHorizontal();
        GUILayout.Label("Float Argument");
        floatInput = GUILayout.TextField(floatInput);
        if (GUILayout.Button("Raise"))
        {
            FloatGameEvent e = target as FloatGameEvent;
            try
            {
                float floatArg = float.Parse(floatInput);
                e.Raise(floatArg);
            }
            finally
            {
            }
        }
        GUILayout.EndHorizontal();
    }
}
