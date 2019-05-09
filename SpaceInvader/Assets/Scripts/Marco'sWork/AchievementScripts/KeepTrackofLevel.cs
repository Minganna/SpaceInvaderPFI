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





    // Use this for initialization
    void Start()
    {
        changeLevel1= Level1;
        changeLevel2 = Level2;
        changeLevel3 = Level3;
    }

    // Update is called once per frame
    void Update()
    {
        Level1 = changeLevel1;
        Level2 = changeLevel2;
        Level3 = changeLevel3;
    }
}
