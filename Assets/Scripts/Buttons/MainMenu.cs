using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    private int buttonPos = 0;
    [SerializeField] private ButtonParent[] buttonList;
    [SerializeField] private ButtonParent[] buttonListBottom;
    private ButtonParent[] activeList;

    public static bool lockMain = false;

    private void Start()
    {
        activeList = buttonList;
        buttonPos = 0;
        activeList[buttonPos].selected = true;
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

            if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.S))
            {
                ChangeRow();
            }
        }

            if (Input.GetKeyDown(KeyCode.P))
            {
                activeList[buttonPos].Use();
            }
    }

    void MoveRight()
    {
        activeList[buttonPos].selected = false;
        if (buttonPos < buttonList.Length - 1)
            buttonPos++;
        else
            buttonPos = 0;
        activeList[buttonPos].selected = true;
    }

    void MoveLeft()
    {
        activeList[buttonPos].selected = false;
        if (buttonPos > 0)
            buttonPos--;
        else
            buttonPos = buttonList.Length - 1;
        activeList[buttonPos].selected = true;
    }

    void ChangeRow()
    {
        activeList[buttonPos].selected = false;
        if (activeList == buttonList)
        {
            if(buttonListBottom.Length != 0)
            {
                if(buttonPos > buttonListBottom.Length - 1)
                {
                    buttonPos = buttonListBottom.Length - 1;
                }

                activeList = buttonListBottom;
            }
        }
        else if (activeList == buttonListBottom)
        {
            if (buttonList.Length != 0)
            {
                if (buttonPos > buttonList.Length - 1)
                {
                    buttonPos = buttonList.Length - 1;
                }

                activeList = buttonList;
            }
        }
        activeList[buttonPos].selected = true;
    }
}
