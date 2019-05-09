using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MiniBoss : MonoBehaviour {

    public GameObject Fire;
    public EnemyHealth bossHealth;
    public GameObject SpawnEnemies;
    public Slider BossLife;
    public ChangeLife lifevar;


    void Start()
    {
        lifevar = GameObject.FindGameObjectWithTag("LoadGame").GetComponent<ChangeLife>();

        BossLife.maxValue = lifevar.NewLife;
        BossLife.value= lifevar.NewLife;
        bossHealth.m_health = lifevar.NewLife;
    }

    void Update()
    {
        BossLife.value = bossHealth.m_health;
        if (bossHealth.m_health < 1)
        {
            BossDeath();
        }
    }

    public void BossDeath()
    {
        Destroy(SpawnEnemies);
        Fire.SetActive(true);
        this.gameObject.GetComponent<Rigidbody>().useGravity = true;
        StartCoroutine(waitToDestroy());


    }

    IEnumerator waitToDestroy()
    {
        yield return new WaitForSeconds(5f);
        Destroy(this.gameObject);
        SceneManager.LoadScene(6);


    }

}
