using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    public Text outputText;
    public SaveName getname;
    public OpenKeyboard closeKy;
    // Use this for initialization
    void Start () {
        outputText = gameObject.GetComponent<Text>();
        closeKy.CloseKeyboard();
       
    }
	
	// Update is called once per frame
	void Update () {
        outputText.text = getname.GetName;
    }
}
