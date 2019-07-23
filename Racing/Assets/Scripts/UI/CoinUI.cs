using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinUI : MonoBehaviour {

    public Text coin;

    [SerializeField]
    private int countCoin = 100;
    private float currentCoin;

	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
        coin.text = currentCoin + " 원";
	}

    // 코인 ++
    public void UPCoin(float _countCoin)
    {
        _countCoin = countCoin;

        currentCoin += _countCoin;
        Debug.Log("돈" +  countCoin + " 원 증가");
    }

    // 코인 --
    public void DownCoin(float _countCoin)
    {
        _countCoin = countCoin;

        // coin 값이 0보다 큰지 체크
        if (currentCoin > 0)
        {
            currentCoin -= _countCoin;
            Debug.Log("돈" + countCoin + " 원 감소");
        }
        
        else
        {
            Debug.Log("감소 할 돈이 읎다 ...");
            currentCoin = 0;
        }
    }

}
