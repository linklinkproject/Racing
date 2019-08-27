using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreItemDatabase : ScriptableObject {

    #region singleton
    private static StoreItemDatabase m_Instance;
    public static StoreItemDatabase Instance
    {
        get {
            if (m_Instance == null)
                m_Instance = Resources.Load("Databases/StoreItemDatabase") as StoreItemDatabase;

            return m_Instance;
        }
    }
    #endregion

    public StoreItemInfo[] items;


    public StoreItemInfo Get(int index)
    {
        return (items[index]);
    }

    public StoreItemInfo GetByID(int ID)
    {
        for (int i = 0; i < this.items.Length; i++)
        {
            if (this.items[i].ID == ID)
                return this.items[i];
        }
        return null;
    }

    //나중에 name 으로 찾아올 메서드 만들면됩니당.
    public GameObject GetByName(string name)
    {

        return null;
    }
}

