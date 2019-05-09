using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLevelstoGold : MonoBehaviour {

    public LoadResults GetStatus;
    public KeepTrackofLevel Level;

    public Renderer[] levelsrend;
	
	// Update is called once per frame
	void Update () {

        if(levelsrend[0]!=null&& levelsrend[1] != null&& levelsrend[2] != null)
        {

            if (Level.changeLevel1 == true && GetStatus.changegold)
            {
                Level.changeLevel1Gold = true;
            }
            if (Level.changeLevel2 == true && GetStatus.changegold)
            {
                Level.changeLevel2Gold = true;
            }
            if (Level.changeLevel3 == true && GetStatus.changegold)
            {
                Level.changeLevel3Gold = true;
            }
            if (Level.changeLevel1 == true && !GetStatus.changegold)
            {
                Level.changeLevel1Gold = false;
            }
            if (Level.changeLevel2 == true && !GetStatus.changegold)
            {
                Level.changeLevel2Gold = false;
            }
            if (Level.changeLevel3 == true && !GetStatus.changegold)
            {
                Level.changeLevel3Gold = false;
            }

            if (Level.changeLevel1Gold == true)
            {
                levelsrend[0].material.color = Color.yellow;
                Level.changeLevel1 = false;
            }
            if (Level.changeLevel2Gold == true)
            {
                levelsrend[1].material.color = Color.yellow;
                Level.changeLevel2 = false;
            }
            if (Level.changeLevel3Gold == true)
            {
                levelsrend[2].material.color = Color.yellow;
                Level.changeLevel3 = false;
            }
            if (Level.changeLevel1Gold == false)
            {
                levelsrend[0].material.color = Color.white;
            }
            if (Level.changeLevel2Gold == false)
            {
                levelsrend[1].material.color = Color.white;
            }
            if (Level.changeLevel3Gold == false)
            {
                levelsrend[2].material.color = Color.white;
            }
        }



    }
}
