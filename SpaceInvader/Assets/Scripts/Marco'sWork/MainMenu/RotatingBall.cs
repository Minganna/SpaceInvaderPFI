using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingBall : MonoBehaviour {

    float x;
    float y;
    float z;
	// Use this for initialization
	void Start () {
        x = transform.rotation.x;
        y = transform.rotation.y;
        z = -90;
	}
	
	// Update is called once per frame
	void Update () {
        x += Time.deltaTime * 30;
        transform.rotation = Quaternion.Euler(x, y, z);
    }
}
