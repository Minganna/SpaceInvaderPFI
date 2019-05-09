using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLife : MonoBehaviour {

    static int EnemyLife;
    public int NewLife;
    static int LeveltoEnter;
    public int NewLevel;


    // Use this for initialization
    void Start () {
        NewLife = EnemyLife;
        NewLevel = LeveltoEnter;
    }
	
	// Update is called once per frame
	void Update () {

        EnemyLife = NewLife;
        LeveltoEnter = NewLevel;
    }
}
