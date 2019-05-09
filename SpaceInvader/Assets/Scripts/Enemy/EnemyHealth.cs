// Rory Clark - https://rory.games - 2019
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
   
    public float m_health = 20f;

    public bool IsBoss=false; 

    public void DamageEnemy(float _damage)
    {
        m_health -= _damage;
        if(m_health <= 0)
        {
            if(IsBoss==false)
            {
                Destroy(gameObject);
            }

        }
    }
}
