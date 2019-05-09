// Rory Clark - https://rory.games - 2019
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    [SerializeField]
    GameObject m_enemyPrefab = null;
    [SerializeField]
    GameObject m_punchPrefab = null;


    GameObject go;

    [SerializeField]
    float m_minSpawnTime = 0.2f, m_maxSpawnTime = 1.5f;
    [SerializeField]
    float m_warmupTime = 1f;
    float m_currentTime = 1f;

    [SerializeField]
    float m_minMaxSpawnWidth = 9.5f;
    float m_minSpawnWidth = 0f;

    public bool IsJoJo = false;

    private void Start()
    {
        m_currentTime = m_warmupTime;
        m_minSpawnWidth = -m_minMaxSpawnWidth;

    }

    void Update()
    {
        m_currentTime -= Time.deltaTime;
        if (m_currentTime <= 0)
        {
            m_currentTime = Random.Range(m_minSpawnTime, m_maxSpawnTime);
            SpawnPrefab();
        }
    }

    void SpawnPrefab()
    {
        if(IsJoJo==false)
        {
          go= Instantiate(m_enemyPrefab);
        }
        if (IsJoJo == true)
        {
            go = Instantiate(m_punchPrefab);
        }

        go.transform.SetParent(transform);
        go.transform.localPosition = new Vector3(0, 0, Random.Range(m_minSpawnWidth, m_minMaxSpawnWidth));
    }
}
