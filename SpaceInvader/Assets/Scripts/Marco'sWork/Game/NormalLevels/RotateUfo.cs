using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateUfo : MonoBehaviour {

	public bool IsPlanet;

	bool stopRotate=false;

	
	// Update is called once per frame
	void Update () {
		if (stopRotate == false) {
			this.transform.Rotate(0, 1, 0);
		}


		if (IsPlanet == true && this.transform.eulerAngles.y >=89&&IsPlanet == true && this.transform.eulerAngles.y <=90) {
			Debug.Log ("got here");
			IsPlanet = false;
			stopRotate = true;
			StartCoroutine (RestartRotate ());
		}
	}



	IEnumerator RestartRotate()
	{
		yield return new WaitForSeconds (3f);
		stopRotate = false;
		IsPlanet = true;


	}
}
