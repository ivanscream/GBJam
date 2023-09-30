using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool rune1Picked, rune2Picked, rune3Picked, rune4Picked, rune5Picked, 
                rune6Picked, rune7Picked, rune8Picked, rune9Picked, OptionalDoor = false, won;

    public bool slot1, slot2, slot3, slot4, slot5, slot6, slot7, slot8, slot9;

    public Dialogue winDialogue;

    [SerializeField] public bool text1Fin, text2Fin, text3Fin, text4Fin, text5Fin, text6Fin, text7Fin,
                text8Fin, text9Fin, text10Fin, text11Fin, text12Fin, text13Fin, text14Fin, text15Fin, text16Fin, text17Fin;
    
    public static Vector3 rune1Pos, rune2Pos, rune3Pos, rune4Pos, rune5Pos, rune6Pos, rune7Pos, rune8Pos, rune9Pos;

    public bool textIsActive, frozenAtText = false;
    public static GameManager gameManager;
    public GameObject textStuff;
    private int runes;
    [SerializeField] private int keys;

    
    public static string enterDir;

    private void Awake()
    {
        gameManager = this;
        OptionalDoor = false;
    }

    void Update()
    {   
        if (textIsActive)
        {
            frozenAtText = true;
            textStuff.SetActive(true);
        }
        else textStuff.SetActive(false);

        if (!textIsActive)
            frozenAtText = false;

        if (frozenAtText)
        {
            Time.timeScale = 0f;
        }

        if (!frozenAtText)
        {
            Time.timeScale = 1f;
        }
           

    }
    private void Start()
    {
        gameManager = this;
        runes = 0;
    }

    public void UpdateRuneCount(int runesToAdd)
    {
        runes += runesToAdd;
    }

    public int GetRuneCount()
    {
        return runes;
    }

    public void UpdateKeyCount(int keysToAdd)
    {
        keys += keysToAdd;
    }
    public int GetKeyCount()
    {
        return keys;
    }

    public static void SetEnterDirection(string exitRoom)
    {
        enterDir = exitRoom;
    }

    public static string GetEnterDirection()
    {
        return enterDir;
    }

    private void FixedUpdate()
    {
        if(gameManager == null)
        {
            gameManager = this;
        }
    }

    public void UpdateRuneLocations(MainRoomRunes[] runes)
    {
        
        foreach (MainRoomRunes rune in runes)
        {
            if (rune.tag == "rune1")
            {
                rune1Pos = rune.transform.position;
            }
            else if (rune.tag == "rune2")
            {
                rune2Pos = rune.transform.position;
            }
            else if (rune.tag == "rune3")
            {
                rune3Pos = rune.transform.position;
            }
            else if (rune.tag == "rune4")
            {
                rune4Pos = rune.transform.position;
            }
            else if (rune.tag == "rune5")
            {
                rune5Pos = rune.transform.position;
            }
            else if (rune.tag == "rune6")
            {
                rune6Pos = rune.transform.position;
            }
            else if (rune.tag == "rune7")
            {
                rune7Pos = rune.transform.position;
            }
            else if (rune.tag == "rune8")
            {
                rune8Pos = rune.transform.position;
            }
            else if (rune.tag == "rune9")
            {
                rune9Pos = rune.transform.position;
            }
        }
        
    }

    public void Win()
    {
        if (!won)
        {
            won = true;
            FindObjectOfType<Motherboard>().GetComponent<SpriteRenderer>().enabled = true;
            FindObjectOfType<Motherboard>().GetComponent<Collider2D>().enabled = true;
        }
    }

    public bool GetSlotStatus(string slotName)
    {
        if(slotName == "slot1")
        {
            return slot1;
        }
        else if (slotName == "slot2")
        {
            return slot2;
        }
        else if (slotName == "slot3")
        {
            return slot3;
        }
        else if (slotName == "slot4")
        {
            return slot4;
        }
        else if (slotName == "slot5")
        {
            return slot5;
        }
        else if (slotName == "slot6")
        {
            return slot6;
        }
        else if (slotName == "slot7")
        {
            return slot7;
        }
        else if (slotName == "slot8")
        {
            return slot8;
        }
        else if (slotName == "slot9")
        {
            return slot9;
        }

        return false;
    }

    public void SetSlotStatus(string slotName, bool value)
    {
        if (slotName == "slot1")
        {
            slot1 = value;
        }
        else if (slotName == "slot2")
        {
            slot2 = value;
        }
        else if (slotName == "slot3")
        {
            slot3 = value;
        }
        else if (slotName == "slot4")
        {
            slot4 = value;
        }
        else if (slotName == "slot5")
        {
            slot5 = value;
        }
        else if (slotName == "slot6")
        {
            slot6 = value;
        }
        else if (slotName == "slot7")
        {
            slot7 = value;
        }
        else if (slotName == "slot8")
        {
            slot8 = value;
        }
        else if (slotName == "slot9")
        {
            slot9 = value;
        }
    }
}
