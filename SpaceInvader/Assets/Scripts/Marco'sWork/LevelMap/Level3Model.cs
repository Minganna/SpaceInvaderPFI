using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level3Model : MonoBehaviour {

	public KeepTrackofLevel cardcollected;
	public GameObject[] bosses;
	public Text WorldNumber;
	
	// Update is called once per frame
	void Update () {

		WorldNumber.text = "World: " + cardcollected.CardGot;

		if (cardcollected.CardGot == 1) {
			Destroy (bosses [0]);
			bosses [1].SetActive (true);
		}
	}
}
