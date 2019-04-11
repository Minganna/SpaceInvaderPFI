using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenKeyboard : MonoBehaviour {


    TouchKeyboard vk = new TouchKeyboard();
    public InputField NameInput;

    public void OpKeyboard()
    {
        {
            NameInput.ActivateInputField();
            vk.ShowOnScreenKeyboard();
        }
    }

    public void CloseKeyboard()
    {
        {
            vk.HideOnScreenKeyboard();
        }
    }
}
