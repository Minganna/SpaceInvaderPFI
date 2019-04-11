using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour {

    public GameObject VR;
    public GameObject Keyboard;
    public GameObject Mouse;
    public Text text;
    public TextMesh VRText;

    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (VR!=null)
        {
            text.text = "VR";
            VRText.text = "VR";
        }
        if (Keyboard != null)
        {
            text.text = "KeyBoard";
            VRText.text = "KeyBoard";
        }
        if (Mouse != null)
        {
            text.text = "Mouse";
            VRText.text = "Mouse";
        }
    }
}
