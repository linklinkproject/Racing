using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoreMenu : MonoBehaviour {

    /*
    // Test용데이터라 일단 SerializeField로 정보 받아왔음. >> 후에 각 아이템의 DB에서 정보를 가져올 예정.
    
    [SerializeField]
    private ItemData[] itemDatas; // 각각 저장해둔 아이템에 대한 정보들 (배열로 저장해서 불러오기)
   
    */

    [SerializeField]
    private GameObject itemCar; // 각 버튼 클릭시 활성화 될 자동차

    [SerializeField]
    private GameObject itemDescArea; // 각 버튼 클릭시 활성화 될 자동차 설명창
    [SerializeField]
    private Text itemDescText; // 각 아이템에 대한 설명 텍스트

    ItemData itemData;

    // Use this for initialization
    void Start () {
        itemCar.SetActive(false);
        itemDescArea.SetActive(false);

        itemData = FindObjectOfType<ItemData>();
        
    }
	
	// Update is called once per frame
	void Update () {
        itemCar.transform.Rotate(Vector3.up, 100f * Time.deltaTime);
        
    }

    public void ButtonOnClick ()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            Debug.Log("button test : " + hit.transform.name); 
        }
        CarCheck(itemData);
       
    }

    public void CarCheck(ItemData _itemData)
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            Debug.Log(hit.transform.name); // 이건 잘됨. 여러군데서 시도해봤는데 위에 네 줄 다같이 있으면 무조건 되는 듯.
        }

        // ray로 객체 이름 받아와서 이름 비교 해주는거 >> 이름 같으면 그 객체안의 item에서 data 받아와서 출력.
        if (hit.transform.name.Equals("TestCar1")) 
        {
            // Debug.Log("TestCar1"); // 띄워짐.

            GameObject.Find("TestCars").transform.Find(hit.transform.name).gameObject.SetActive(true); //객체 이름 같은거 찾아서 띄워주기 

            _itemData = hit.transform.GetComponent<Item>().itemData;

            Debug.Log(_itemData.itemName + " " +  _itemData.itemDesc);

            itemData = _itemData; // 받아온 객체의 아이템정보로 바꿔줘서 출력해주기
            //itemDescText.text = "바보바보바보야";
           // itemDescText.text = itemData.itemDesc + ""; // *** null 떠버림

            //GameObject.Find("TestCars").transform.Find(hit.transform.name).gameObject.SetActive(true); //객체 이름 같은거 찾아서 띄워주기 
            GameObject.Find("TestCars").transform.Find(hit.transform.name).gameObject.transform.Rotate(Vector3.up, 100f * Time.deltaTime); // 빙글빙글
            
            //itemCar.SetActive(true);
            itemDescArea.SetActive(true);

        }
       

    }


    // 아직 아이템 추가는 보류
    public void AddItme(ItemData _itemData) // >> 각 아이템 정보를 매개변수로 받아서 출력해주기. >> 일단은 테스트용
    {
        // itemDescText.text = _itemData.itemDesc; >> 아이템 정보를 전송 받았을 때,

        // Test용 임시 데이터
       
    }
   

}
