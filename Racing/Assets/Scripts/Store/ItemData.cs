using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "New Item/item")]

public class ItemData : ScriptableObject {

    public string itemName; // 아이템(자동차) 이름
    [TextArea]
    public string itemDesc; // 아이템 설명.
    public Sprite itemImage; // 아이템 이미지.
    public GameObject itemPrefab; // 아이템 프리팹.

	
}
