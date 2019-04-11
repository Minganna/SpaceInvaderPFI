using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceBar : MonoBehaviour {
    Renderer rend;
    public GameObject BoomParticle;
    private ParticleSystem BoomPs;
    public int WhichOne;
    public GameObject VRSet;
    public GameObject Keyboard;
    public GameObject Mouse;
    public bool startburn=false;


    // Use this for initialization
    void Start () {
		rend = GetComponent<Renderer>();

            BoomParticle = GameObject.FindGameObjectWithTag("Boom");
            BoomPs = BoomParticle.GetComponent<ParticleSystem>();
        
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            gameObject.transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.z / 2);
            rend.material.SetColor("_Color", Color.grey);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            gameObject.transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.z * 2);
            rend.material.SetColor("_Color", Color.white);

        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Invaders")
        {
            gameObject.transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.z / 2);
            rend.material.SetColor("_Color", Color.grey);
            StartCoroutine(BackToNormal());
        }
        if (col.gameObject.name == "Bullet(Clone)")
        {
            BoomParticle.transform.position = this.transform.position;
            BoomPs.Play();
            if(WhichOne==1)
            {
                Destroy(Mouse);
                Destroy(VRSet);
            }
            if (WhichOne == 2)
            {
                Destroy(Keyboard);
                Destroy(VRSet);

            }
            if (WhichOne == 3)
            {
                Destroy(Mouse);
                Destroy(Keyboard);

            }
            startburn = true;
            Destroy(gameObject);
 
        }

    }

     IEnumerator BackToNormal()
    {
        yield return new WaitForSeconds(1f);
        gameObject.transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.z *2);
        rend.material.SetColor("_Color", Color.white);

    }
}
