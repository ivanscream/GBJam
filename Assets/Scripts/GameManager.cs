using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool rune1Picked, rune2Picked, rune3Picked, rune4Picked, rune5Picked, 
                rune6Picked, rune7Picked, rune8Picked, rune9Picked;

    public bool textIsActive, destroyTextTrigger;
    public static GameManager gameManager;
    public GameObject textStuff;
    private int runes;
    [SerializeField] private int keys;

    
    public static string enterDir;

    private void Awake()
    {
        gameManager = this.gameObject.GetComponent<GameManager>();
    }

    void Update()
    {
        if (textIsActive)
        {
            textStuff.SetActive(true);
            GameManager.gameManager.destroyTextTrigger = false;
        }
        else textStuff.SetActive(false);
        
    }
    private void Start()
    {
        gameManager = this.gameObject.GetComponent<GameManager>();
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
            gameManager = this.gameObject.GetComponent<GameManager>();
        }
    }
}
