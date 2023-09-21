using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool rune1Active, rune2Active, rune3Active, rune4Active, rune5Active, 
                rune6Active, rune7Active, rune8Active, rune9Active;
    public static GameManager gameManager;
    private int runes;

    public Text runeCount;
    public Text keyCount;

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
