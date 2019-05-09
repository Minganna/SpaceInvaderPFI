using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLevelstoGold : MonoBehaviour {

    public LoadResults GetStatus;
    public KeepTrackofLevel Level;

    public Renderer[] levelsrend;
	
	// Update is called once per frame
	void Update () {

        if(Level.changeLevel1==true&&GetStatus.changegold)
        {
            levelsrend[0].material.color = Color.yellow;
        }
        if (Level.changeLevel2 == true && GetStatus.changegold)
        {
            levelsrend[1].material.color = Color.yellow;
        }
        if (Level.changeLevel3 == true && GetStatus.changegold)
        {
            levelsrend[2].material.color = Color.yellow;
        }

    }
}
