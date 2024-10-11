using UnityEngine;
using UnityEditor;

public class JerseyChange : EditorWindow
{
    Color matColor = Color.white;

    [MenuItem("HitWicket/JerseyChange")]
    static void Init()
    {
        EditorWindow window = GetWindow(typeof(JerseyChange));
        window.Show();
    }

    void OnGUI()
    {
        matColor = EditorGUILayout.ColorField("New Color", matColor);

        if (GUILayout.Button("Change!"))
            ChangeColors();
    }

    private void ChangeColors()
    {
        GameObject go = GameObject.Find("Jersey");
            
            {
                Renderer rend = go.GetComponent<Renderer>();

                if (rend != null)
                    rend.sharedMaterial.color = matColor;
            }
    }
}