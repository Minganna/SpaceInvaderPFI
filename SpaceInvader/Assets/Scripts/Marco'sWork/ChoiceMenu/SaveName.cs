using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveName : MonoBehaviour {

    static string PlayerName;
    public string GetName;

	// Use this for initialization
	void Start () {
        GetName = PlayerName;
	}
	
	// Update is called once per frame
	void Update () {
        PlayerName = GetName;	
	}
}
