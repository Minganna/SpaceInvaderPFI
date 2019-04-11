using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeShaderAndBurn : MonoBehaviour {

    private Renderer MyRendered;
    float Threshold;
    bool Burningstarting = false;
    public SpaceBar SpaceBarScript;
    public GameObject CommonText;
    public GameObject ThreeDText;

    // Use this for initialization
    void Start()
    {
        MyRendered = gameObject.GetComponent<Renderer>();

    
    }

    // Update is called once per frame
    void Update()
    {
        Burningstarting = SpaceBarScript.startburn;
        if (Burningstarting)
        {
            MyRendered.material.shader = Shader.Find("Custom/Burning");
            Threshold += 0.009f;
            MyRendered.material.SetFloat("_Threshold", Threshold);
            if (UnityEngine.XR.XRDevice.isPresent == false)
            {
                StartCoroutine(PlayText());
            }
            if (UnityEngine.XR.XRDevice.isPresent == true)
            {
                StartCoroutine(Play3DText());
            }
        }
    }

    IEnumerator PlayText()
    {
        yield return new WaitForSeconds(2.0f);
        CommonText.SetActive(true);

    }
    IEnumerator Play3DText()
    {
        yield return new WaitForSeconds(2.0f);
        ThreeDText.SetActive(true);

    }

}
