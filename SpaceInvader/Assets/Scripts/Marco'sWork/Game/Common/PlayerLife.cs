using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLife : MonoBehaviour {

    public Slider HealthBar;
    public GameObject EnemySpawner;
    public Animator[] characters;
    void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Enemy")
        {

            HealthBar.value -= 10;
            if(HealthBar.value<1)
            {
                Destroy(EnemySpawner);
                characters[0].SetBool("Death", true);
                characters[1].SetBool("Victory", true);
            }
        }
    }
}
