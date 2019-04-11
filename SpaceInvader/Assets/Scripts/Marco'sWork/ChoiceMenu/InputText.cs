using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputText : MonoBehaviour {

    public GameObject PasteText;
    public Text[] inputText;
    public SaveName keepchanges;
    

	// Use this for initialization
	void Start () {
        inputText= new Text[2];
        inputText[0] = gameObject.GetComponent<Text>();
        inputText[1] = PasteText.GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        inputText[1].text = inputText[0].text;
        keepchanges.GetName = inputText[1].text;

    }
}
