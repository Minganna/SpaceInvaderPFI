using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public GameObject[] Levels;
    public ChangeLife life;
    public KeepTrackofLevel whatisgold;
	
	// Update is called once per frame
	void Update () {
		if(Levels[0]==null)
        {

            life.NewLife = 30;
            life.NewLevel = 0;
            whatisgold.changeLevel1 = true;
            StartCoroutine(StartLevel());

        }
        if (Levels[1] == null)
        {
            whatisgold.changeLevel2 = true;
            life.NewLife = 100;
            life.NewLevel = 0;
            StartCoroutine(StartLevel());

        }
        if (Levels[2] == null)
        {
            whatisgold.changeLevel3 = true;
            life.NewLife = 30;
            life.NewLevel = 1;
            StartCoroutine(StartLevel());

        }
    }

    IEnumerator StartLevel()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(1);
    }
}
