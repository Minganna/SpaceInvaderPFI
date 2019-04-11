using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvadersFalling : MonoBehaviour {

    public GameObject MainMenu;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(transform.position.y<=-50)
        {

            MainMenu.SetActive(true);
            Destroy(gameObject);
        }
		
	}
}
