using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepTrackofLevel : MonoBehaviour {

    static bool Level1 = false;
    public bool changeLevel1;
    static bool Level2 = false;
    public bool changeLevel2 = false;
    static bool Level3 = false;
    public bool changeLevel3 = false;
    static bool Level1Gold = false;
    public bool changeLevel1Gold;
    static bool Level2Gold = false;
    public bool changeLevel2Gold = false;
    static bool Level3Gold = false;
    public bool changeLevel3Gold = false;





    // Use this for initialization
    void Start()
    {
        changeLevel1= Level1;
        changeLevel2 = Level2;
        changeLevel3 = Level3;
        changeLevel1Gold = Level1Gold;
        changeLevel2Gold = Level2Gold;
        changeLevel3Gold = Level3Gold;
    }

    // Update is called once per frame
    void Update()
    {
        Level1 = changeLevel1;
        Level2 = changeLevel2;
        Level3 = changeLevel3;
        Level1Gold = changeLevel1Gold;
        Level2Gold = changeLevel2Gold;
        Level3Gold = changeLevel3Gold;
    }
}
