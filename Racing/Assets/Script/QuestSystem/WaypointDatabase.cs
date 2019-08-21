using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{
    public class WaypointDatabase : ScriptableObject
    {
        #region singleton
        private static WaypointDatabase m_Instance;
        public static WaypointDatabase Instance
        {
            get {
                if (m_Instance == null)
                    m_Instance = Resources.Load("Databases/WaypointDatabases") as WaypointDatabase;

                return m_Instance;
            }
        }
        #endregion

        public WaypointInfo[] waypointInfos;


        public WaypointInfo Get(int index)
        {
            return (waypointInfos[index]);
        }

        public WaypointInfo GetByID(int ID)
        {
            for (int i = 0; i < this.waypointInfos.Length; i++)
            {
                // if (this.waypointInfos[i].ID == ID)
                return this.waypointInfos[i];
            }
            return null;
        }
    }
}
