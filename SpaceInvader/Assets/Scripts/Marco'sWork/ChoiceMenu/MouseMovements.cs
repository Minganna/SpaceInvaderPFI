using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovements : MonoBehaviour {

    Vector3 MouseLocation;
  

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        MouseLocation = Input.mousePosition;
        MouseLocation.z = 27.39f;
        MouseLocation.y = 50f;
        transform.position = Camera.main.ScreenToWorldPoint(MouseLocation);
	}
}
