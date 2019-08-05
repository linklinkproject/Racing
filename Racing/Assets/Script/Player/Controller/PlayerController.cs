using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class AxleInfo
{
    public WheelCollider leftWheel;
    public WheelCollider rightWheel;
    public bool motor;
    public bool steering;
}

public class PlayerController : MonoBehaviour {

    private Rigidbody mRigidbody;

    public Joystick joystick; //조이스틱 컨트롤러

    public float moveSpeed; //나중에 자동차 정보 가져와서 적용해야함


    public List<AxleInfo> axleInfos;
    public float maxMotorTorque;
    public float maxSteeringAngle;

    // finds the corresponding visual wheel
    // correctly applies the transform
    public void ApplyLocalPositionToVisuals(WheelCollider collider)
    {
        if (collider.transform.childCount == 0)
        {
            return;
        }

        Transform visualWheel = collider.transform.GetChild(0);

        Vector3 position;
        Quaternion rotation;
        collider.GetWorldPose(out position, out rotation);

        visualWheel.transform.position = position;
        visualWheel.transform.rotation = rotation;
    }

    public void FixedUpdate()
    {
        float motor = maxMotorTorque * Input.GetAxis("Vertical");
        float steering = maxSteeringAngle * Input.GetAxis("Horizontal");

        foreach (AxleInfo axleInfo in axleInfos)
        {
            if (axleInfo.steering)
            {
                axleInfo.leftWheel.steerAngle = steering;
                axleInfo.rightWheel.steerAngle = steering;
            }
            if (axleInfo.motor)
            {
                axleInfo.leftWheel.motorTorque = motor;
                axleInfo.rightWheel.motorTorque = motor;
            }
            ApplyLocalPositionToVisuals(axleInfo.leftWheel);
            ApplyLocalPositionToVisuals(axleInfo.rightWheel);
        }
    }


 //   private void Awake()
 //   {
 //       mRigidbody = GetComponent<Rigidbody>();
 //   }

 //   // Use this for initialization
 //   void Start () {
		
	//}
	
	//// Update is called once per frame
	//void Update () {
 //       JoysticMove();
 //   }

 //   private void JoysticMove()
 //   {
 //       Vector3 moveVector = (Vector3.right * joystick.Horizontal + Vector3.forward * joystick.Vertical);

 //       if (moveVector != Vector3.zero)
 //       {
 //           transform.rotation = Quaternion.LookRotation(moveVector);
 //           mRigidbody.AddForce(transform.forward * moveSpeed);
 //           //transform.Translate(moveVector * moveSpeed * Time.deltaTime, Space.World);
 //           //mRigidbody.MovePosition(transform.position + moveVector * moveSpeed * Time.deltaTime);
 //       }
 //   }
}
