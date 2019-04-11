// Rory Clark - https://rory.games - 2019
using UnityEngine;

public class BulletDamage : MonoBehaviour
{

    private ParticleSystem BoomPs;
    [SerializeField]
    float m_damage = 10f;
    public GameObject BoomParticle;
    [SerializeField]
    public GameObject EnemyPos = null;

    private void Start()
    {
        BoomParticle = GameObject.FindGameObjectWithTag("Boom");
        BoomPs = BoomParticle.GetComponent<ParticleSystem>();
    }



    private void OnTriggerEnter(Collider other)
    {

        // Damage the enemy if we hit one, destroy ourselves
        BoomParticle.transform.position = EnemyPos.transform.position;
        BoomPs.Play();
        EnemyHealth enemy = other.GetComponent<EnemyHealth>();
        if (enemy != null)
        {
            enemy.DamageEnemy(m_damage);
            Destroy(gameObject);
        }
    }


}
