using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private Rigidbody mRigidbody;

    public Joystick joystick; //조이스틱 컨트롤러

    public float moveSpeed; //나중에 자동차 정보 가져와서 적용해야함




    private void Awake()
    {
        mRigidbody = GetComponent<Rigidbody>();
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        JoysticMove();
    }

    private void JoysticMove()
    {
        Vector3 moveVector = (Vector3.right * joystick.Horizontal + Vector3.forward * joystick.Vertical);

        if (moveVector != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(moveVector);
            mRigidbody.AddForce(transform.forward * moveSpeed);
            //transform.Translate(moveVector * moveSpeed * Time.deltaTime, Space.World);
            //mRigidbody.MovePosition(transform.position + moveVector * moveSpeed * Time.deltaTime);
        }
    }
}
