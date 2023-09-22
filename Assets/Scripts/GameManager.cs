using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool rune1Picked, rune2Picked, rune3Picked, rune4Picked, rune5Picked, 
                rune6Picked, rune7Picked, rune8Picked, rune9Picked;
    public static GameManager gameManager;
    private int runes;

    public Text runeCount;

    private void Start()
    {
        gameManager = this.gameObject.GetComponent<GameManager>();
        runes = 0;
    }

    public void UpdateRuneCount(int runesToAdd)
    {
        runes += runesToAdd;
        runeCount.text =runes.ToString();
    }

}
