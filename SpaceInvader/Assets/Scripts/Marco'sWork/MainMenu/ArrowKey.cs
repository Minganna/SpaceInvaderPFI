using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowKey : MonoBehaviour {

    Renderer rend;
    public bool Left;

    // Use this for initialization
    void Start()
    {
        rend = GetComponent<Renderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow)&&Left==true)
        {
            
            gameObject.transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y/2, transform.localScale.z);
            rend.material.SetColor("_Color", Color.grey);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && Left == false)
        {

            gameObject.transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y/2, transform.localScale.z);
            rend.material.SetColor("_Color", Color.grey);
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow) && Left == true)
        {

            gameObject.transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y *2, transform.localScale.z);
            rend.material.SetColor("_Color", Color.white);
        }
        if (Input.GetKeyUp(KeyCode.RightArrow) && Left == false)
        {

            gameObject.transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y *2, transform.localScale.z);
            rend.material.SetColor("_Color", Color.white);
        }



    }

}
