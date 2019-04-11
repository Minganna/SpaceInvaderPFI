using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NotSupported : MonoBehaviour {

    public ChangeText CT;
    public GameObject NotSupportedText;
    public GameObject SupportedText;

    // Use this for initialization
    void Awake() {
        StartCoroutine(returntomenu());

    }

    IEnumerator returntomenu()
    {
        yield return new WaitForSeconds(2.0f);
        if (UnityEngine.XR.XRDevice.isPresent == true && CT.VRText.text != "VR")
        {
            NotSupportedText.SetActive(true);
            yield return new WaitForSeconds(5.0f);
            SceneManager.LoadScene(0);
        }
        if (UnityEngine.XR.XRDevice.isPresent == true && CT.VRText.text == "VR")
        {
            SupportedText.SetActive(true);
            yield return new WaitForSeconds(5.0f);
            SceneManager.LoadScene(2);
        }

    }
}
