using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.VR;

public class YesNo : MonoBehaviour {

    public GameObject YesCube;
    public GameObject NoCube;
    public GameObject ReturningToMenu;
    public Text Selection;
    public Text YesText;
    public Text NoText;
    int choice=0;
    int counter=5;
    public ChangeText GetSelectionScript;
    public string GetSelection;
    public GameObject AllText;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if(YesCube!=null&&NoCube!=null)
        {
            GetSelection = GetSelectionScript.text.text;
        }

		if (YesCube==null&&choice==0)
        {
            choice = 1;
            Destroy(AllText);
       
        }
        if (NoCube == null && choice == 0)
        {
            choice = 2;
            Destroy(AllText);
           
        }

        if (choice==1)
        {
            StartCoroutine(FlashingText());
            NoText.text = "";
        }
        if (choice == 2)
        {
            StartCoroutine(FlashingText());
            YesText.text = "";
        }

    }

    IEnumerator FlashingText()
    {
        if(choice == 1)
        {
            ReturningToMenu.SetActive(true);
            Selection.text = "Loading Menu with your selected choice";
            choice = 4;
            yield return new WaitForSeconds(0.5f);
            YesText.text = "";
            yield return new WaitForSeconds(0.5f);
            YesText.text = "Yes";
            choice = 1;
            counter += 1;
        }
        if (choice == 2)
        {
            ReturningToMenu.SetActive(true);
            Selection.text = "Returning to Main Menu, please wait";
            choice = 4;
            yield return new WaitForSeconds(0.5f);
            NoText.text = "";
            yield return new WaitForSeconds(0.5f);
            NoText.text = "No"; 
            choice = 2;
            counter -= 1;
        }

        if (counter==0)
        {
            SceneManager.LoadScene(0);
        }
        if (counter == 10&&GetSelection=="KeyBoard")
        {
            Debug.Log("Loading Keyboard Menu");
            SceneManager.LoadScene(3);
        }
        if (counter == 10 && GetSelection == "VR")
        {
           Debug.Log(UnityEngine.XR.XRDevice.isPresent);

            if(UnityEngine.XR.XRDevice.isPresent==false)
            {
                choice = 9;
                Selection.text = "No VR device connected, returning to the main menu";
                yield return new WaitForSeconds(2.0f);
                SceneManager.LoadScene(0);

            }
            if (UnityEngine.XR.XRDevice.isPresent == true)
            {
                Debug.Log("Loading VR Menu");
                SceneManager.LoadScene(2);
            }
            
        }
        if (counter == 10 && GetSelection == "Mouse")
        {
            Debug.Log("Loading Mouse Menu");
            SceneManager.LoadScene(4);
        }


    }

}
