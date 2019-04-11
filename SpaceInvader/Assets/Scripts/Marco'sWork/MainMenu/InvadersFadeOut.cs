using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvadersFadeOut : MonoBehaviour {

    private bool Fade=false;
    Renderer rend;

    // Use this for initialization
    void Start () {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update () {
		if (Fade==true)
        {
            
            Color color = rend.material.color;
            color.a = 0f;
            rend.material.color = color;
        }
	}

    public void FadeOut()
    {
        Fade = true;
    
    }
}
