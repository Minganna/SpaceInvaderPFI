using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateWorld : MonoBehaviour {

    public GameObject[] DesiredLevel;
    public int LevelToLoad;
    public ChangeLife level;
    public Camera DummyCamera;


	// Use this for initialization
	void Start () {
        StartCoroutine(waittoload());
       
	}

    IEnumerator waittoload()
    {
        yield return new WaitForSeconds(1f);
        Destroy(DummyCamera);
        LevelToLoad = level.NewLevel;
        Instantiate(DesiredLevel[LevelToLoad], this.gameObject.transform.position, Quaternion.identity);
    }
	

}
