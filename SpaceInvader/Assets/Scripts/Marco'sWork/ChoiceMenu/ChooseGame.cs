using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChooseGame : MonoBehaviour {

    Renderer rend;
    public GameObject BoomParticle;
    private ParticleSystem BoomPs;
    public int WhichOne;
    public GameObject Menu;
    public GameObject NamePanel;

   


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
            gameObject.transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y / 2, transform.localScale.z );
            rend.material.SetColor("_Color", Color.grey);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            gameObject.transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y * 2, transform.localScale.z );
            rend.material.SetColor("_Color", Color.white);

        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(5);
        }
    }

    void OnCollisionEnter(Collision col)
    {
     
        if (col.gameObject.name == "Bullet(Clone)")
        {
            BoomParticle.transform.position = this.transform.position;
            BoomPs.Play();
            Destroy(Menu);
            if (WhichOne == 0)
            {
                NamePanel.SetActive(true);
            }
            
        }

    }

}
