using UnityEngine;
using UnityEditor;

// Custom editor work to let the unity editor user raise an event from the editor while the game is playing. Great for testing.
[CustomEditor(typeof(GameEvent))]
public class GameEventEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        GUI.enabled = Application.isPlaying;
        GameEvent e = target as GameEvent;
        if (GUILayout.Button("Raise"))
        {
            e.Raise();
        }
    }
}
