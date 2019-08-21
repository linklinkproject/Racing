using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class StoreItemDatabaseEditor{

    private static string GetSavePath()
    {
        return EditorUtility.SaveFilePanelInProject("New StoreItem database", "New StoreItem database", "asset", "Create a new StoreItem database.");
    }

    [MenuItem("Assets/Create/Databases/storeItem Database")]
    public static void CreateDatabase()
    {
        string assetPath = GetSavePath();
        StoreItemDatabase asset = ScriptableObject.CreateInstance("StoreItemDatabase") as StoreItemDatabase;  //scriptable object
        AssetDatabase.CreateAsset(asset, AssetDatabase.GenerateUniqueAssetPath(assetPath));
        AssetDatabase.Refresh();
    }
}
