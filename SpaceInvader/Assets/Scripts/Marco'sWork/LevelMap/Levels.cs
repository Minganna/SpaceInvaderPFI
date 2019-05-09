using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Levels : MonoBehaviour {

    Renderer rend;
    public GameObject BoomParticle;
    private ParticleSystem BoomPs;
    public int level;




    // Use this for initialization
    void Start()
    {
        rend = GetComponent<Renderer>();

        BoomParticle = GameObject.FindGameObjectWithTag("Boom");
        BoomPs = BoomParticle.GetComponent<ParticleSystem>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            gameObject.transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y / 2, transform.localScale.z);
            rend.material.SetColor("_Color", Color.grey);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            gameObject.transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y * 2, transform.localScale.z);
            rend.material.SetColor("_Color", Color.white);

        }
    }

    void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.name == "Bullet(Clone)")
        {
            BoomParticle.transform.position = this.transform.position;
            BoomPs.Play();
            Destroy(gameObject);
        }

    }
}
