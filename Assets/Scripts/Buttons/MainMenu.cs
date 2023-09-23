using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    private int buttonPos = 0;
    [SerializeField] private ButtonParent[] buttonList;

    public static bool lockMain = false;

    private void Start()
    {
        buttonList[buttonPos].selected = true;
    }

    private void Update()
    {
        if (!lockMain)
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                MoveRight();
            }

            if (Input.GetKeyDown(KeyCode.A))
            {
                MoveLeft();
            }
        }

            if (Input.GetKeyDown(KeyCode.P))
            {
                buttonList[buttonPos].Use();
            }
    }

    void MoveRight()
    {
        buttonList[buttonPos].selected = false;
        if (buttonPos < buttonList.Length - 1)
            buttonPos++;
        else
            buttonPos = 0;
        buttonList[buttonPos].selected = true;
    }

    void MoveLeft()
    {
        buttonList[buttonPos].selected = false;
        if (buttonPos > 0)
            buttonPos--;
        else
            buttonPos = buttonList.Length - 1;
        buttonList[buttonPos].selected = true;
    }
}
