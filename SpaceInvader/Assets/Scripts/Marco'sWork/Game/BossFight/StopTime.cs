using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopTime : MonoBehaviour {

    bool StopTimes = true;
    public Animator DIO;
    public Animator Jotaro;
    public PlayerMovement pm;
    public PlayerShoot ph;
    public MouseMovements mm;
    public GameObject Panel;


	
    // Update is called once per frame
    void Update () {
        if(StopTimes==true)
        {
            StopTimes = false;
            StartCoroutine(ZAWARUDO());
        }
	}

    IEnumerator ZAWARUDO()
    {
        yield return new WaitForSeconds(30f);
        DIO.SetBool("Stop", true);
        Jotaro.SetBool("Stop", true);
        Panel.SetActive(true);
        pm.canMove = false;
        ph.CanMove = false;
        mm.canMove = false;
        yield return new WaitForSeconds(1f);
        DIO.SetBool("Stop", false);
        yield return new WaitForSeconds(10f);
        Panel.SetActive(false);
        Jotaro.SetBool("Stop", false);
        StopTimes = true;
        pm.canMove = true;
        ph.CanMove = true;
        mm.canMove = true;

    }
}
