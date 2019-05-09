using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Boss : MonoBehaviour {

    public Animator Bossfight;
    public EnemyHealth bossHealth;
    public GameObject SpawnEnemies;
    public Slider BossLife;

    void Update()
    {
        BossLife.value = bossHealth.m_health;
        if(bossHealth.m_health<1)
        {
            BossDeath();
        }
    }

    public void BossDeath()
    {
        Destroy(SpawnEnemies);
        Bossfight.SetBool("Death", true);
        StartCoroutine(waitToDestroy());


    }

    IEnumerator waitToDestroy()
    {
        yield return new WaitForSeconds(5f);
        Destroy(Bossfight.gameObject);
        SceneManager.LoadScene(6);

    }


}
