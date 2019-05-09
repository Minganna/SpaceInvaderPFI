// Rory Clark - https://rory.games - 2019
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{

    [SerializeField]
    GameObject m_bulletPrefab = null;
    [SerializeField]
    GameObject m_punchPrefab = null;

    [SerializeField]
    Transform m_spawnPosition = null;

    [SerializeField]
    KeyCode m_fireKey = KeyCode.Space;


   public bool isJojo = false;
    public bool CanMove = true;

    [SerializeField]
    float m_fireRate = 0.25f;
    float m_currentFireTimer = 0f;
    GameObject go;

    void Update()
    {
        if (m_currentFireTimer > 0)
        {
            m_currentFireTimer -= Time.deltaTime;
        }

        // GetKeyDown and GetKey will happen at different times
        // GetKeyDown will happen as soon as the user presses the key
        // GetKey will work when it is held
        if ((Input.GetKeyDown(m_fireKey) || Input.GetKey(m_fireKey)) && m_currentFireTimer <= 0 || Input.GetButtonDown("Fire1") || Input.GetButtonDown("Fire1") && m_currentFireTimer <= 0)
        {
            m_currentFireTimer = m_fireRate;
            SpawnBullet();
        }
    }

    void SpawnBullet()
    {
        if(CanMove==true)
        {

            if (isJojo == false)
            {
                go = Instantiate(m_bulletPrefab);
            }
            if (isJojo == true)
            {
                go = Instantiate(m_punchPrefab);
            }
            go.transform.position = m_spawnPosition.position;
        }

    }
   
}
