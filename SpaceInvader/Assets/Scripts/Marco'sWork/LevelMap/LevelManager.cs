using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public GameObject[] Levels;
    public ChangeLife life;
    public KeepTrackofLevel whatisgold;
	public KeepTrackofLevel World;
	
	// Update is called once per frame
	void Update () {
		if(Levels[0]==null)
        {
			if (World.CardGot == 0) {
				life.NewLife = 30;
				life.NewLevel = 0;
				whatisgold.changeLevel1 = true;
				StartCoroutine (StartLevel ());
			}
			if (World.CardGot == 1) {
				life.NewLife = 60;
				life.NewLevel = 2;
				whatisgold.changeLevel1 = true;
				StartCoroutine (StartLevel ());
			}

        }
        if (Levels[1] == null)
        {
			if (World.CardGot == 0) {
				whatisgold.changeLevel2 = true;
				life.NewLife = 50;
				life.NewLevel = 0;
				StartCoroutine (StartLevel ());
			}
			if (World.CardGot == 1) {
				life.NewLife = 100;
				life.NewLevel = 2;
				whatisgold.changeLevel2 = true;
				StartCoroutine (StartLevel ());
			}

        }
        if (Levels[2] == null)
        {
			if (World.CardGot == 0) {
				whatisgold.changeLevel3 = true;
				life.NewLife = 100;
				life.NewLevel = 1;
				StartCoroutine (StartLevel ());
			}
			if (World.CardGot == 1) {
				life.NewLife = 100;
				life.NewLevel = 3;
				whatisgold.changeLevel3 = true;
				StartCoroutine (StartLevel ());
			}

        }
    }

    IEnumerator StartLevel()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(1);
    }
}
