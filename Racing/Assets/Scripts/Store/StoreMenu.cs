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

    // Use this for initialization
    void Start () {
        //itemCar.SetActive(false);
        itemDescArea.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
       // itemCar.transform.Rotate(Vector3.up, 100f * Time.deltaTime);
        
    }

    public void ButtonOnClick ()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            Debug.Log("button test : " + hit.transform.name);
        }
        CarCheck();
       
    }

    public void CarCheck()
    {
        //StoreItemDatabase 스크립트 안에 있는 메서드에 접근해서 가져올 수 있음.
        //StoreItemDatabase 스크립트에 name으로 찾는 메서드를 만들면 Equals 같이 쓸 수 있음
        Debug.Log(StoreItemDatabase.Instance.Get(0).name);

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            Debug.Log("00 : " + hit.transform.name); // 이건 잘됨. 여러군데서 시도해봤는데 위에 네 줄 다같이 있으면 무조건 되는 듯.
            
        }
        // ray로 객체 이름 받아와서 이름 비교 해주는거 >> 이름 같으면 그 객체안의 item에서 data 받아와서 출력.
        
        // Debug.Log("TestCar1"); // 띄워짐.

        GameObject frame = GameObject.Find("temp");//.Find(hit.transform.name).gameObject.SetActive(true); //객체 이름 같은거 찾아서 띄워주기 

        print("asd : " + frame);

        print("hit.transform.name : " + hit.transform.name);

        Instantiate(StoreItemDatabase.Instance.Get(1).prefab,frame.transform);
            
       
        //GameObject.Find("TestCars").transform.Find(hit.transform.name).gameObject.SetActive(true); //객체 이름 같은거 찾아서 띄워주기 
        //GameObject.Find("TestCars").transform.Find(hit.transform.name).gameObject.transform.Rotate(Vector3.up, 100f * Time.deltaTime); // 빙글빙글

        //itemCar.SetActive(true);
        itemDescArea.SetActive(true);

        



    }

}
