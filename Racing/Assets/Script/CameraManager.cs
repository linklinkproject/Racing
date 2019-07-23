using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour {

    public GameObject target;

    private Transform targetTransform;

	// Use this for initialization
	void Start () {
        targetTransform = target.transform;
    }
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(targetTransform.position.x, transform.position.y, targetTransform.position.z);
	}
}
