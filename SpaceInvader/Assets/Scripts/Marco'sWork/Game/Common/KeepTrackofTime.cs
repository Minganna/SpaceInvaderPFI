using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeepTrackofTime : MonoBehaviour {

    public Text timepassed;
    public GameObject Menu;
    PlayerLife PL = null;
    public LoadResults achievements;
    public int count=0;
    public bool canstart=false;

    void Update()
    {
        if(canstart==true)
        {
         PL = GameObject.FindGameObjectWithTag("PL").GetComponent<PlayerLife>();
        }


        if (Input.GetKeyDown(KeyCode.Escape)&&!Menu.activeSelf)
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

        if(canstart==true)
        {
            if (PL.HealthBar.value < 200)
            {

                achievements.changehealth = false;
            }
        }
       
    }



}
