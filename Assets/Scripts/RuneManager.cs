using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuneManager : MonoBehaviour
{
    [SerializeField] private RuneSlot[] slots, secondarySlots;
    [SerializeField] private MainRoomRunes[] runes;
    bool winCondition;

    public static RuneManager instance;
    static bool firstStart = true;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(this);
    }

    private void Start()
    {
        instance = this;
        if (runes.Length == 0 || slots.Length == 0)
        {
            FillArrays();
        }

        if (!firstStart)
        {
            MoveRuneLocations();
        }
        else
        {
            firstStart = false;
        }
        
    }

    private void MoveRuneLocations()
    {
        foreach(MainRoomRunes rune in runes)
        {
            if (rune.tag == "rune1")
            {
                rune.transform.position = GameManager.rune1Pos;
            }
            else if (rune.tag == "rune2")
            {
                rune.transform.position = GameManager.rune2Pos;
            }
            else if (rune.tag == "rune3")
            {
                rune.transform.position = GameManager.rune3Pos;
            }
            else if (rune.tag == "rune4")
            {
                rune.transform.position = GameManager.rune4Pos;
            }
            else if (rune.tag == "rune5")
            {
                rune.transform.position = GameManager.rune5Pos;
            }
            else if (rune.tag == "rune6")
            {
                rune.transform.position = GameManager.rune6Pos;
            }
            else if (rune.tag == "rune7")
            {
                rune.transform.position = GameManager.rune7Pos;
            }
            else if (rune.tag == "rune8")
            {
                rune.transform.position = GameManager.rune8Pos;
            }
            else if (rune.tag == "rune9")
            {
                rune.transform.position = GameManager.rune9Pos;
            }
        }
    }

    private void FixedUpdate()
    {
        if(instance == null)
        {
            instance = this;
        }
        if (runes.Length == 0 || slots.Length == 0)
        {
            FillArrays();
        }
        GameManager.gameManager.UpdateRuneLocations(runes);


        UpdateWinBool();
        

        if (winCondition)
        {
            GameManager.gameManager.Win();
        }
    }

    

    void UpdateWinBool()
    {
        foreach(RuneSlot slot in slots)
        {
            //find if any aren't filled and return out of function if one is not
            if (!slot.slotFilled)
            {
                winCondition = false;
                return;
            }

        }
            //set true if you get through the foreach loop without breaking
            winCondition = true;
    }




    public void FillArrays()
    {
        runes = GameObject.FindObjectsOfType<MainRoomRunes>();
        //slots = GameObject.FindObjectsOfType<RuneSlot>();
    }

    public MainRoomRunes[] GetRunes()
    {
        return runes;
    }

    public bool GetSecondaryCondition()
    {
        foreach (RuneSlot slot in secondarySlots)
        {
            //find if any aren't filled and return out of function if one is not
            if (!slot.slotFilled)
            {
                return false;
            }

        }
        //set true if you get through the foreach loop without breaking
        return true;
    }
}
