using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;

[InitializeOnLoad]
public class Startup
{
    static Startup()
    {
        Debug.Log("Up and running");
        //EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo();
        //EditorSceneManager.OpenScene("Assets/Starter Scene.unity");

        //EditorSceneManager.OpenScene(Application.dataPath + "Assets/Starter Scene.unity");
        //EditorUtility.LoadWindowLayout("Default");
    }
}
