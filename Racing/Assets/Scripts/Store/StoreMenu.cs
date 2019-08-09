using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoreMenu : MonoBehaviour {

    // Test용데이터라 일단 SerializeField로 정보 받아왔음. >> 후에 각 아이템의 DB에서 정보를 가져올 예정.
    [SerializeField]
    private GameObject itemCar; // 각 버튼 클릭시 활성화 될 자동차
    [SerializeField]
    private GameObject itemDescArea; // 각 버튼 클릭시 활성화 될 자동차 설명창
    [SerializeField]
    private ItemData[] itemDatas; // 각각 저장해둔 아이템에 대한 정보들 (배열로 저장해서 불러오기)
    [SerializeField]
    private Text itemDescText; // 각 아이템에 대한 설명 텍스트
    
    // Use this for initialization
    void Start () {
        itemCar.SetActive(false);
        itemDescArea.SetActive(false);
     
        
    }
	
	// Update is called once per frame
	void Update () {
        itemCar.transform.Rotate(Vector3.up, 100f * Time.deltaTime);
        
    }

    public void ButtonOnClick ()
    {
        itemCar.SetActive(true);
        itemDescArea.SetActive(true);

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            Debug.Log(hit.transform.name);
        }

        // AddItme(); >> 누른 버튼안의 정보를 담아야하는데 hitInfo로 넣을지 눌렀을 때 전송시킬지 고민중.
        itemCar.transform.Rotate(Vector3.up, 100f * Time.deltaTime);
    }

    public void AddItme(ItemData _itemData) // >> 각 아이템 정보를 매개변수로 받아서 출력해주기. >> 일단은 테스트용
    {
        // itemDescText.text = _itemData.itemDesc; >> 아이템 정보를 전송 받았을 때,

        // Test용 임시 데이터
       
    }
   

}
