using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //x시간 안동안 z의 값이 일정 숫자에서 0으로 변경됨
    public IEnumerator PlayerRevert()
    {
        // 140 <= z <= 220 이면 동작
        while (transform.rotation.z >= 140 && transform.rotation.z <= 220)
        {

            yield return new WaitForSeconds(0.1f);

        }

    }
}
