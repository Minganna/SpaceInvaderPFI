using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateWorld : MonoBehaviour {

    public GameObject[] DesiredLevel;
    public int LevelToLoad;
    public ChangeLife level;
    public Camera DummyCamera;
    public KeepTrackofTime StartCheckLife;


	// Use this for initialization
	void Start () {
        StartCoroutine(waittoload());
       
	}

    IEnumerator waittoload()
    {
        yield return new WaitForSeconds(1f);
        LevelToLoad = level.NewLevel;
        Instantiate(DesiredLevel[LevelToLoad], this.gameObject.transform.position, Quaternion.identity);
        StartCheckLife.canstart = true;
        yield return new WaitForSeconds(1f);
        Destroy(DummyCamera);

    }
	

}
