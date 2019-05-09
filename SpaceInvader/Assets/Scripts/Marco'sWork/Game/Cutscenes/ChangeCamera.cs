using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour {

    public GameObject[] StartGame;
    public CameraFollow cam;

	// Use this for initialization
	void Start () {

        StartCoroutine(StartTheGame());
	}

    IEnumerator StartTheGame()
    {
        yield return new WaitForSeconds(3f);
        StartGame[0].SetActive(true);
        cam.Target = StartGame[0].transform;
        yield return new WaitForSeconds(3f);
        cam.Offset = new Vector3(-10, 20, 0);
        yield return new WaitForSeconds(2f);
        StartGame[1].SetActive(true);
        StartGame[3].SetActive(true);
        Destroy(StartGame[2]);


    }
}
