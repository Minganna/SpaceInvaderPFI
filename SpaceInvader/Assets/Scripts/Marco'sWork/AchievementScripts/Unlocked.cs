using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unlocked : MonoBehaviour {

    Shader shader1;
    Shader shader2;
    Renderer rend;
    public int whichone;
    public LoadResults achievementstatus;
    public Color color;
    float timetowait;

    public Renderer GoldRend;


    void Start()
    {
        rend = GetComponent<Renderer>();
        shader2 = Shader.Find("Custom/Toon");
        shader1 = Shader.Find("Custom/Ghost");
        color = Color.white;
        if (whichone == 1 && achievementstatus.changeTime == true)
        {
            timetowait = 2f;
            StartCoroutine(GetAchievement());

        }
        if (whichone == 0 && achievementstatus.changeAmmo == true)
        {
            timetowait = 1f;
            StartCoroutine(GetAchievement());

        }
        if (whichone == 2 && achievementstatus.changehealth == true)
        {
            timetowait = 3f;
            StartCoroutine(GetAchievement());

        }

        if(achievementstatus.changehealth&&achievementstatus.changeTime&&achievementstatus.changeAmmo)
        {
            timetowait = 5f;
            StartCoroutine(GetGold());
        }

        if (!achievementstatus.changehealth || !achievementstatus.changeTime || !achievementstatus.changeAmmo)
        {
            achievementstatus.changegold = false;
        }
    }


    IEnumerator GetAchievement()
    {
        Debug.Log("I'm here");
        yield return new WaitForSeconds(timetowait);
        if (rend.material.shader == shader1)
        {
            rend.material.shader = shader2;
            rend.material.color = color;
        }
    }

    IEnumerator GetGold()
    {
        Debug.Log("Gold!");
        yield return new WaitForSeconds(timetowait);
        GoldRend.material.color = Color.yellow;
        achievementstatus.changegold = true;
    }

}
