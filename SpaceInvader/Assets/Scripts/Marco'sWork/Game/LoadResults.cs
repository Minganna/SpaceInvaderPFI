using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadResults : MonoBehaviour {

    static bool TimeAchievement=true;
    public bool changeTime;
    static bool AmmoAchievement = true;
    public bool changeAmmo=false;
    static bool HealthAchievement = true;
    public bool changehealth = true;
    static bool Goldlevel;
    public bool changegold = false;




    // Use this for initialization
    void Start () {
        changeTime = TimeAchievement;
        changeAmmo = AmmoAchievement;
        changehealth = HealthAchievement;
        changegold = Goldlevel;
	}
	
	// Update is called once per frame
	void Update () {
        TimeAchievement = changeTime;
        AmmoAchievement = changeAmmo;
        HealthAchievement = changehealth;
        Goldlevel = changegold;
	}
}
