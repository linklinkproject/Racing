using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

public class WaypointDatabaseEditor{

    private static string GetSavePath()
    {
        return EditorUtility.SaveFilePanelInProject("New waypoint database", "New waypoint database", "asset", "Create a new waypoint database.");
    }

    [MenuItem("Assets/Create/Databases/waypoint Database")]
    public static void CreateDatabase()
    {
        string assetPath = GetSavePath();
        WaypointDatabase asset = ScriptableObject.CreateInstance("WaypointDatabase") as WaypointDatabase;  //scriptable object
        AssetDatabase.CreateAsset(asset, AssetDatabase.GenerateUniqueAssetPath(assetPath));
        AssetDatabase.Refresh();
    }
}
