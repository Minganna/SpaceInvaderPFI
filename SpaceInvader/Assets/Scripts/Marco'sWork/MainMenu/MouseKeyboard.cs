using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseKeyboard : MonoBehaviour {
    float timeLeft;
    float visibleCursorTimer = 10.0f;
    float cursorPosition;
    bool catchCursor = true;
    public GameObject Player;
    void Update()
    {
        if (catchCursor)
        {
            catchCursor = false;
            cursorPosition = Input.GetAxis("Mouse X");
        }
        if (Input.GetAxis("Mouse X") == cursorPosition)
        {

            timeLeft -= Time.deltaTime;
            if (timeLeft < 0)
            {
                timeLeft = visibleCursorTimer;
                Cursor.visible = false;
                catchCursor = true;
            }
        }
        else
        {
            timeLeft = visibleCursorTimer;
            Cursor.visible = true;
            Player.GetComponent<PlayerMovement>().enabled = false;
            Player.GetComponent<MouseMovements>().enabled = true;

        }

        if(Input.anyKeyDown)
        {
            if (!Input.GetMouseButtonDown(0))
            {
                Player.GetComponent<MouseMovements>().enabled = false;
                Player.GetComponent<PlayerMovement>().enabled = true;
            }

        }
    }


}
