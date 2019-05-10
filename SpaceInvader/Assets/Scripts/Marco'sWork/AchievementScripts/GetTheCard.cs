using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GetTheCard : MonoBehaviour {

	public KeepTrackofLevel CardUnlocked;





	void OnTriggerEnter(Collider other)
	{
		Destroy (other.gameObject);

		if (this.gameObject.tag == "Card1") {
			CardUnlocked.CardGot = 1;

		}
			StartCoroutine (GoToReward ());
	

	}


	IEnumerator GoToReward()
	{
		yield return new WaitForSeconds (2f);
		SceneManager.LoadScene (5);
	}


}
