using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace UnityEngine
{
    [Serializable]
    public class StoreItemInfo
    {

        public string name; // 아이템(자동차) 이름
        public int ID; // Item Index
        [TextArea]
        public string desc; // 아이템 설명.
        public Sprite image; // 아이템 이미지.
        public GameObject prefab; // 아이템 프리팹.
    }
}