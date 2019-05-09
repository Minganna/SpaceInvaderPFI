using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeepTrackofTime : MonoBehaviour {

    public Text timepassed;
    public GameObject Menu;
    public PlayerLife PL;
    public LoadResults achievements;
    public int count=0;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)&&!Menu.activeSelf)
        {
            Menu.SetActive(true);
            return;
        }
        if (Input.GetKeyDown(KeyCode.Escape) && Menu.activeSelf)
        {
            Menu.SetActive(false);
            return;
        }
        //Output the time since the level loaded to the screen using this label
        timepassed.text=  Time.timeSinceLevelLoad.ToString();

        if(Time.timeSinceLevelLoad>20f)
        {
            achievements.changeTime = false;
        }

        if(Input.GetKeyUp(KeyCode.Space)||Input.GetMouseButtonUp(0))
        {
            count++;
        }

        if(count<20)
        {
            achievements.changeAmmo = true;
        }
        if (count > 20)
        {
            achievements.changeAmmo = false;
        }

        if(PL.HealthBar.value<200)
        {
            achievements.changehealth = false;
        }
    }

}
