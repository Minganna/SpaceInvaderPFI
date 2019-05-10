using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World2 : MonoBehaviour {

	public KeepTrackofLevel Worldtwo;
	public GameObject[] Treasure;
	public KeepTrackofLevel Card;

	static bool Changekeep=false;
	public bool changed=true;


	// Use this for initialization
	void Start () {
		Changekeep = changed;
	}
	
	// Update is called once per frame
	void Update () {

		if (Worldtwo.changeLevel1Gold == true && Worldtwo.changeLevel2Gold == true && Worldtwo.changeLevel3Gold == true) 
		{
			Treasure[0].SetActive (true);
			Treasure[1].SetActive (true);
			Treasure[0].transform.Rotate (1, 0, 0);

		}


		if (Card.CardGot == 1) 
		{
			if (Card.gameObject == null) 
			{
				changed = false;
			}
			if (changed == false) {
				changed = true;
				Changekeep = changed;
				Worldtwo.changeLevel1Gold = false;
				Worldtwo.changeLevel2Gold = false;
				Worldtwo.changeLevel3Gold = false;
			}

		}
	}
}
